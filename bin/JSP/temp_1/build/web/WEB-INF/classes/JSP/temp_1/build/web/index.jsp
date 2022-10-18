<%-- 
    Document   : login
    Created on : Aug 25, 2022, 11:44:25 AM
    Author     : dhanu
--%>

<%@page import="Model.User"%>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta charset="UTF-8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <meta http-equiv="X-UA-Compatible" content="ie=edge">
        <title>Sign Up Form</title>

        <!-- Font Icon -->
        <link rel="stylesheet" href="fonts/material-icon/css/material-design-iconic-font.min.css">
        <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.0/dist/css/bootstrap.min.css">

        <!-- Main css -->
        <link rel="stylesheet" href="css/style.css">


    </head>
    <body>
        <%

            int sessionId = 0;

            Cookie cookies[] = request.getCookies();

            for (Cookie c : cookies) {
                if (c.getName().equals("session_id")) {
                    sessionId = Integer.parseInt(c.getValue());
                }
            }

            if (sessionId != 0) {
                response.sendRedirect("info.jsp");
            }

        %>
        <div class="main">
            <!-- Sing in  Form -->
            <section class="sign-in">
                <div class="container">
                    <div class="signin-content">
                        <div class="signin-image">
                            <figure><img src="images/signin-image.jpg" alt="sing up image"></figure>
                            <a href="register.jsp" class="signup-image-link">Create an account</a>
                        </div>

                        <div class="signin-form">
                            <h2 class="form-title">Log In</h2>
                            <form name="login" method="POST" action="./UserLoginServlet" class="register-form" id="login-form">
                                <div class="form-group">
                                    <label for="email"><i class="zmdi zmdi-account material-icons-name"></i></label>
                                    <input type="email" name="email" id="email" placeholder="Enter your Email" autofocus/>
                                </div>
                                <div class="form-group">
                                    <label for="password"><i class="zmdi zmdi-lock"></i></label>
                                    <input type="password" name="password" id="your_pass" placeholder="Enter your Password"/>
                                </div>
                                <div class="form-group form-button">
                                    <input type="submit" name="signin" id="signin" class="form-submit" value="Log in" onclick="loginFormValidate()"/>
                                </div>
                                <%                                    HttpSession httpSession = request.getSession();

                                    // User user = new User();
                                    if (httpSession.getAttribute("error_code") == "1") {
                                %>
                                <div class="alert alert-danger" role="alert">
                                    The email address or password that you've entered doesn't match any account. <a href="register.jsp" class="alert-link">Sign up for an account</a>
                                </div>
                                <%
                                    }
                                %>

                                <div id="test">

                                </div>

                            </form>
                        </div>
                    </div>
                </div>
            </section>

        </div>

        <!-- JS -->
        <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.0/dist/js/bootstrap.bundle.min.js"></script>
        <script src="vendor/jquery/jquery.min.js"></script>
        <script>
                                        function loginFormValidate() {
                                            var email = document.login.email.value;
                                            var password = document.login.password.value;

                                            var mailformat = /^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/;

                                            if (email == "" && password == "") {
                                                document.getElementById("test").innerHTML = "<div class='alert alert-danger' role='alert'>Please enter your Email and Password!</div>";
                                            } else if (email == "") {
                                                document.getElementById("test").innerHTML = "<div class='alert alert-danger' role='alert'>Please enter your Email address!</div>";
                                            } else if (!email.match(mailformat))
                                            {
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
