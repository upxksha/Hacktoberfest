/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Controller;

import Model.User;
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
public class UserLogin {

    Connection connection;
    Statement statement;

    public int userLogin(User user) {
        int result;
        PreparedStatement preparedStatement;

        String email = user.getEmail();
        String password = user.getPassword();

        DBConnection dBConnection = new DBConnection();
        connection = dBConnection.getConnection();

        try {
            preparedStatement = connection.prepareStatement("{CALL SP_user_AuthenticateUser(?, ?)}");
            preparedStatement.setString(1, email);
            preparedStatement.setString(2, password);

            ResultSet resultSet = preparedStatement.executeQuery();

            if (resultSet.next()) {
                int userId = resultSet.getInt(1);

                int sessionId = resultSet.getInt(6);
                preparedStatement = connection.prepareStatement("{CALL SP_SESSION_LOGIN(?)}");
                preparedStatement.setInt(1, sessionId);
                resultSet = preparedStatement.executeQuery();

                user.setSessionId(sessionId);
                user.setUserId(userId);
                result = 0;
            } else {
                // Username and password are incorrect
                result = 1;
            }
            return result;
        } catch (SQLException ex) {
            Logger.getLogger(UserLogin.class.getName()).log(Level.SEVERE, null, ex);

            // Have a database error
            return 2;
        }

    }
}
