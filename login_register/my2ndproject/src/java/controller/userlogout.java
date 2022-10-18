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
public class userlogout {
     Connection connection;
    Statement statement;

    public int UserLogOut(user User) {
        int sessionId = User.getSessionid();

        PreparedStatement preparedStatement;
        DBconnection dBConnection = new DBconnection();
        Connection connection = dBConnection.getConnection();

        try {
            preparedStatement = connection.prepareStatement("{CALL SP_SESSION_LOGOUT(?)}");
            preparedStatement.setInt(1, sessionId);

            ResultSet resultSet = preparedStatement.executeQuery();
            return 7;
        } catch (SQLException ex) {
            Logger.getLogger(userlogout.class.getName()).log(Level.SEVERE, null, ex);
            return 8;
        }
    }

}
