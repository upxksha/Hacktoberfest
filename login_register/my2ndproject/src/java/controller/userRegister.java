/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package controller;

import java.sql.CallableStatement;
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
public class userRegister {
     Connection connection;
    Statement statement;

    public int userRegister(user User) {

       // String fullname = User.getFullname();
        String email = User.getEmail();
        String username = User.getUsername();
        String password = User.getPassword();
        
        
        
        String user_pass = username + " " + password;
        char[] chars = user_pass.toCharArray();
        int len = chars.length;
        char[] char_arrays = new char[len];
        int count=0;
        for(char c:chars){
            c+=2;
            char_arrays[count]=c; 
            count++;
            
        } 
        String encrypted_name =String.valueOf(char_arrays);  
        
        

        DBconnection dbconnection = new DBconnection();
        connection = dbconnection.getConnection();

        PreparedStatement pre_state;
        

        try {
            String sql = "{CALL SP_user_AuthenticateUser(?,?)}";
            CallableStatement call_state = connection.prepareCall(sql);

            call_state.setString(1, username);
            call_state.setString(2, password);
            ResultSet rs = call_state.executeQuery();

            if (!rs.next()) {
                String query = "{CALL SP_session_Insert(?)}";
                call_state = connection.prepareCall(query);
                call_state.setString(1,encrypted_name);
                rs = call_state.executeQuery();
                rs.next();
                int sess_id = rs.getInt(1);
                        
                
                
                
                query = "{CALL SP_user_insert(?,?,?,?)}";
                call_state = connection.prepareCall(query);

                //call_state.setString(1, fullname);
                call_state.setString(1, username);
                call_state.setString(2, email);
                call_state.setString(3, password);
                call_state.setInt(4,sess_id);
                

                rs = call_state.executeQuery();
                User.setSessionid(sess_id);
                User.setSessionname(encrypted_name);
                
                return 1;
            } else {
                return 2;
            }

        } catch (SQLException ex) {
            Logger.getLogger(userRegister.class.getName()).log(Level.SEVERE, null, ex);

            return 3;
        }

    }
}
