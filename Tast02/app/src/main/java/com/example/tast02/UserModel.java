package com.example.tast02;

public class UserModel {
    public String first_name;
    public String last_name;
    public String Email;
    public String Password;

    public UserModel(String first_name, String last_name, String email, String password) {
        this.first_name = first_name;
        this.last_name = last_name;
        this.Email = email;
        this.Password = password;
    }
}
