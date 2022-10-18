<%-- 
    Document   : register
    Created on : Aug 25, 2022, 11:45:53 AM
    Author     : dhanu
--%>

<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>

    <head>
        <meta charset="UTF-8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <meta http-equiv="X-UA-Compatible" content="ie=edge">
        <title>Sign Up Form by Colorlib</title>

        <!-- Font Icon -->
        <link rel="stylesheet" href="fonts/material-icon/css/material-design-iconic-font.min.css">
        <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.0/dist/css/bootstrap.min.css">

        <!-- Main css -->
        <link rel="stylesheet" href="css/style.css">
    </head>
    <body>
        <div class="main">
            <!-- Sign up form -->
            <section class="signup">
                <div class="container">
                    <div class="signup-content">
                        <div class="signup-form">
                            <h2 class="form-title">Sign up</h2>
                            <form name="register" method="POST" action="./UserInsertServlet" class="register-form" id="register-form">
                                <div class="form-group">
                                    <label for="name"><i class="zmdi zmdi-account material-icons-name"></i></label>
                                    <input type="text" name="name" id="name" placeholder="Your Name" autofocus/>
                                </div>
                                <div class="form-group">
                                    <label for="age"><i class="zmdi zmdi-account material-icons-name"></i></label>
                                    <input type="text" name="age" id="age" placeholder="Your Age" />
                                </div>
                                <div class="form-group">
                                    <label for="email"><i class="zmdi zmdi-email"></i></label>
                                    <input type="email" name="email" id="email" placeholder="Your Email" required/>
                                </div>
                                <div class="form-group">
                                    <label for="password"><i class="zmdi zmdi-lock-outline"></i></label>
                                    <input type="password" name="password" id="password" placeholder="Enter Password" required/>
                                </div>
                                <div class="form-group">
                                    <input type="checkbox" name="agree-term" id="agree-term" class="agree-term" value="1"/>
                                    <label for="agree-term" class="label-agree-term"><span><span></span></span>I agree all statements in  <a href="#" class="term-service">Terms of service</a></label>
                                </div>
                                <div class="form-group form-button">
                                    <input type="submit" name="signup" id="signup" class="form-submit" value="Register" onclick="registerFormValidate()"/>
                                </div>
                                <%
                                    HttpSession httpSession = request.getSession();

                                    // User user = new User();
                                    if (httpSession.getAttribute("error_code") == "4") {
                                %>
                                <div class="alert alert-danger" role="alert">
                                    The email address and password is already used for create an account. Please enter a different email address
                                </div>
                                <%
                                    }
                                %>
                                <div id="test">

                                </div>
                            </form>
                        </div>
                        <div class="signup-image">
                            <figure><img src="images/signup-image.jpg" alt="sing up image"></figure>
                            <a href="index.jsp" class="signup-image-link">I am already member</a>
                        </div>
                    </div>
                </div>
            </section>
        </div>

        <!-- JS -->
        <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.0/dist/js/bootstrap.bundle.min.js"></script>
        <script src="vendor/jquery/jquery.min.js"></script>
        <script>
                                        function registerFormValidate() {
                                            var name = document.register.name.value;
                                            var age = document.register.age.value;
                                            var email = document.register.email.value;
                                            var password = document.register.password.value;
                                            var mailformat = /^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/;

                                            if (name == "") {
                                                document.getElementById("test").innerHTML = "<div class='alert alert-danger' role='alert'>Please enter your Name!</div>";
                                            } else if (age == "") {
                                                document.getElementById("test").innerHTML = "<div class='alert alert-danger' role='alert'>Please enter your Age!</div>";
                                            } else if (isNaN(age)) {
                                                document.getElementById("test").innerHTML = "<div class='alert alert-danger' role='alert'>Age should be a numeric value!</div>";
                                            } else if (email == "") {
                                                document.getElementById("test").innerHTML = "<div class='alert alert-danger' role='alert'>Please enter your Email address!</div>";
                                            } else if (!email.match(mailformat)) {
                                                document.getElementById("test").innerHTML = "<div class='alert alert-danger' role='alert'>You have entered an invalid email address!</div>";
                                            } else if (password == "") {
                                                document.getElementById("test").innerHTML = "<div class='alert alert-danger' role='alert'>Please enter your Password!</div>";
                                            } else if (password.length < 6) {
                                                document.getElementById("test").innerHTML = "<div class='alert alert-danger' role='alert'>Password should have at least 6 characters!</div>";
                                            }
                                        }
        </script>
    </body>
</html>
