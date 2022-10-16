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
public class UserLogOut {

    Connection connection;
    Statement statement;

    public int UserLogOut(User user) {
        int sessionId = user.getSessionId();

        PreparedStatement preparedStatement;
        DBConnection dBConnection = new DBConnection();
        connection = dBConnection.getConnection();

        try {
            preparedStatement = connection.prepareStatement("{CALL SP_SESSION_LOGOUT(?)}");
            preparedStatement.setInt(1, sessionId);

            ResultSet resultSet = preparedStatement.executeQuery();
            return 6;
        } catch (SQLException ex) {
            Logger.getLogger(UserLogOut.class.getName()).log(Level.SEVERE, null, ex);
            return 7;
        }

    }
}
