/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Controller;

import Model.User;
import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.logging.Level;
import java.util.logging.Logger;

/**
 *
 * @author dhanu
 */
public class UserRegister {

    Connection connection;
    Statement statement;

    public int UserRegister(User user) {
        boolean result = false;
        int key = 7;
        int i = 0;

        String name = user.getName();
        String email = user.getEmail();
        int age = user.getAge();
        String password = user.getPassword();

        String mergedName = name + " " + password;
        char[] chars = mergedName.toCharArray();
        int len = chars.length;
        char[] charArray = new char[len];

        for (char c : chars) {
            c += key;
            charArray[i] = c;
            i++;

        }

        String sessionName = new String(charArray);

        PreparedStatement preparedStatement;
        DBConnection dBConnection = new DBConnection();
        connection = dBConnection.getConnection();

        try {
            preparedStatement = connection.prepareStatement("{CALL SP_user_AuthenticateUser(?, ?)}");
            preparedStatement.setString(1, email);
            preparedStatement.setString(2, password);

            ResultSet resultSet = preparedStatement.executeQuery();

            if (!resultSet.next()) {
                String query = "{CALL SP_SESSION_INSERT (?)}";
                CallableStatement stmt = connection.prepareCall(query);

                stmt.setString(1, sessionName);
                ResultSet rs = stmt.executeQuery();
                rs.next();

                int sessionId = rs.getInt(1);
                query = "{CALL SP_user_insert (?, ?, ?, ?, ?)}";
                stmt = connection.prepareCall(query);

                stmt.setString(1, name);
                stmt.setInt(2, age);
                stmt.setString(3, email);
                stmt.setString(4, password);
                stmt.setInt(5, sessionId);

                rs = stmt.executeQuery();

                // Insert Success
                user.setSessionId(sessionId);
                user.setSessionName(sessionName);
                return 3;
            } else {

                // Error. Have same email addresses for different accounts.
                return 4;
            }

        } catch (SQLException ex) {
            Logger.getLogger(UserRegister.class.getName()).log(Level.SEVERE, null, ex);
            return 5;

        }
    }
}
