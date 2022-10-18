/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package controller;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.logging.Level;
import java.util.logging.Logger;
import model.user;

/**
 *
 * @author DELL
 */
public class userlogin {

    Connection connection;
    Statement statement;

    public int userlogin(user User) {
        int result;
        PreparedStatement preparedStatement;

        String username = User.getUsername();
        String password_p = User.getPassword();

        DBconnection dbconnection = new DBconnection();
        connection = dbconnection.getConnection();

        try {
            preparedStatement = connection.prepareStatement("{CALL SP_user_AuthenticateUser(?, ?)}");
            preparedStatement.setString(1, username);
            preparedStatement.setString(2, password_p);

            ResultSet resultSet = preparedStatement.executeQuery();
            if (resultSet.next()) {
                int userid = resultSet.getInt(1);
                int sessionid = resultSet.getInt(5);
                User.setUserid(userid);
                User.setSessionid(sessionid);
                result = 4;
            } else {
                result = 5;
            }
            return result;
        } catch (SQLException ex) {
            Logger.getLogger(userlogin.class.getName()).log(Level.SEVERE, null, ex);
            return 6;
        }

    }
}
