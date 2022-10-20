package com.example.tast02;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.text.TextUtils;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ProgressBar;
import android.widget.Toast;

import com.google.android.gms.tasks.OnCompleteListener;
import com.google.android.gms.tasks.Task;
import com.google.firebase.auth.AuthResult;
import com.google.firebase.auth.FirebaseAuth;
import com.google.firebase.auth.FirebaseUser;
import com.google.firebase.database.DatabaseReference;
import com.google.firebase.database.FirebaseDatabase;

public class Activity3 extends AppCompatActivity {
    EditText fName, lName, email, password;
    Button register;
    FirebaseAuth firebaseAuth;
    ProgressBar progressBar;
    private UserModel userModel;

    // Write a message to the database
    public FirebaseDatabase database = FirebaseDatabase.getInstance("https://login-and-register-form-73173-default-rtdb.asia-southeast1.firebasedatabase.app/");
    public DatabaseReference myRef;

    public String uid;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_3);

        fName = findViewById(R.id.txtFirstName);
        lName = findViewById(R.id.txtLastName);
        email = findViewById(R.id.txtEmail);
        password = findViewById(R.id.txtPassword);
        register = findViewById(R.id.btnRegister);
        firebaseAuth = FirebaseAuth.getInstance();
        progressBar = findViewById(R.id.progressBar);



        // If the user is already logged in
        if (firebaseAuth.getCurrentUser() != null) {
            startActivity(new Intent(getApplicationContext(), Dashboard.class));
            finish();
        }


        register.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                String first_name = fName.getText().toString().trim();
                String last_name = lName.getText().toString().trim();
                String Email = email.getText().toString().trim();
                String Password = password.getText().toString().trim();

                userModel = new UserModel(first_name, last_name, Email, Password);
                myRef = database.getReference("details");

                boolean error = true;

                if (TextUtils.isEmpty(first_name)) {
                    fName.setError("Enter your First Name");
                    error = false;
                }

                if (TextUtils.isEmpty(last_name)) {
                    lName.setError("Enter your Last Name");
                    error = false;
                }

                if (TextUtils.isEmpty(Email)) {
                    email.setError("Enter your Email address");
                    error = false;
                }

                if (TextUtils.isEmpty(Password)) {
                    password.setError("Enter your password");
                    error = false;
                }

                if (Password.length() < 6) {
                    password.setError("The Password must contain at least 6 Characters");
                    error = false;
                }

                if (error) {
                    progressBar.setVisibility(View.VISIBLE);

                    // Firebase authentication
                    firebaseAuth.createUserWithEmailAndPassword(Email, Password).addOnCompleteListener(new OnCompleteListener<AuthResult>() {
                        @Override
                        public void onComplete(@NonNull Task<AuthResult> task) {
                            // Check the task is Successful
                            if (task.isSuccessful()) {
                                FirebaseUser user = firebaseAuth.getCurrentUser();
                                uid = user.getUid();

                                // Set Values
                                myRef.child("Users").child(uid).setValue(userModel);

                                // Display the Success Message
                                Toast.makeText(Activity3.this, "User Created Successfully", Toast.LENGTH_SHORT).show();
                                startActivity(new Intent(getApplicationContext(), Dashboard.class));

                            } else {
                                // Display the Error Message
                                Toast.makeText(Activity3.this, "Failed to create the User\nError! " + task.getException().getMessage(), Toast.LENGTH_SHORT).show();
                            }
                        }
                    });
                }

            }
        });

    }
}