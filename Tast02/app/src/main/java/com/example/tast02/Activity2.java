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

public class Activity2 extends AppCompatActivity {
    EditText email, password;
    Button btnLogin;
    FirebaseAuth firebaseAuth;
    ProgressBar progressBar;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_2);

        email = findViewById(R.id.txtEMail);
        password = findViewById(R.id.txtPASSWORD);
        btnLogin = findViewById(R.id.btnLOGIN);
        progressBar = findViewById(R.id.progressBar3);

        firebaseAuth = FirebaseAuth.getInstance();

        btnLogin.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                String Email = email.getText().toString().trim();
                String Password = password.getText().toString().trim();
                boolean error = true;

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

                    // Authenticate the user
                    firebaseAuth.signInWithEmailAndPassword(Email, Password).addOnCompleteListener(new OnCompleteListener<AuthResult>() {
                        @Override
                        public void onComplete(@NonNull Task<AuthResult> task) {
                            if (task.isSuccessful()) {
                                // Display the Success Message
                                Toast.makeText(Activity2.this, "User Logged in Successfully", Toast.LENGTH_SHORT).show();

                                // Move to User Profile page
                                startActivity(new Intent(getApplicationContext(), Dashboard.class));
                            } else {
                                // Display the Error Message
                                Toast.makeText(Activity2.this, "Failed to Login\nError! " + task.getException().getMessage(), Toast.LENGTH_SHORT).show();
                            }
                        }
                    });
                }
            }
        });
    }
}