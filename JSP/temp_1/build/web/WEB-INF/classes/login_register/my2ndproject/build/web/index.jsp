<%-- 
    Document   : register
    Created on : Aug 31, 2022, 6:36:08 PM
    Author     : DELL
--%>

<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta charset="UTF-8" />
        <meta name="viewport" content="width=device-width, initial-scale=1.0" />
        <script
            src="https://kit.fontawesome.com/64d58efce2.js"
            crossorigin="anonymous"
        ></script>
        <link rel="stylesheet" href="css/register.css" />
        <title>Sign in & Sign up Form</title>
    </head>
    <body>

        <%
            int sessionid = 0;
            Cookie cookie_array[] = request.getCookies();
            for (Cookie c : cookie_array) {
                if (c.getName().equals("session_id")) {
                    sessionid = Integer.parseInt(c.getValue());
                }
            }
            if (sessionid != 0) {
                response.sendRedirect("info.jsp");
            }
        %>

        <div class="container">
            <div class="forms-container">
                <div class="signin-signup">
                    <form name="login" action="./loginServlet" class="sign-in-form" method="POST">
                        <h2 class="title">Sign in</h2>
                        <div class="input-field">
                            <i class="fas fa-user"></i>
                            <input type="text" placeholder="Username" name="username"  autofocus/>
                        </div>
                        <div id="vali_username1" style="color: red;">

                        </div>
                        <div class="input-field">
                            <i class="fas fa-lock"></i>
                            <input type="password" placeholder="Password" name="password" required/>
                        </div>
                        <div id="vali_password1" style="color: red;">

                        </div>
                        <input type="submit" value="Login" class="btn solid" onclick="loginvalidate()"/>

                    </form>
                    <form name = "register" action="./registerServlet" class="sign-up-form" method="POST">
                        <h2 class="title">Sign up</h2>
                        <div class="input-field">
                            <i class="fas fa-user"></i>
                            <input type="text" placeholder="Username" name="username"  autofocus/>
                        </div>
                        <div id="vali_username" style="color: red;">

                        </div>


                        <div class="input-field">
                            <i class="fas fa-envelope"></i>
                            <input type="email" placeholder="Email" name="email" required />
                        </div>
                        <div id="vali_email" style="color: red;">

                        </div>
                        <div class="input-field">
                            <i class="fas fa-lock"></i>
                            <input type="password" placeholder="Password" name="password" required/>
                        </div>
                        <div id="vali_password" style="color: red;">

                        </div>
                        <input type="submit" class="btn" value="Sign up" onclick="registerValidate()"/>

                    </form>
                </div>
            </div>

            <div class="panels-container">
                <div class="panel left-panel">
                    <div class="content">
                        <h3>New here ?</h3>
                        <p>
                            Join with us and enjoy your life. 
                        </p>
                        <button class="btn transparent" id="sign-up-btn">
                            Sign up
                        </button>
                    </div>
                    <img src="images/undraw_secure_login_pdn4.svg" class="image" alt="" />
                </div>
                <div class="panel right-panel">
                    <div class="content">
                        <h3>One of us ?</h3>
                        <p>
                            If you are with us , Please login and continue your journey.
                        </p>
                        <button class="btn transparent" id="sign-in-btn">
                            Sign in
                        </button>
                    </div>
                    <img src="images/undraw_add_user_re_5oib.svg" class="image" alt="" />
                </div>
            </div>
        </div>

        <script src="js/login.js"></script>

        <%
            HttpSession httpSession = request.getSession();
            if (httpSession.getAttribute("error_code") == "2") {
        %>     
        <script>
                            window.alert("Please enter different email address and passoword.");
        </script>
        <%
            }

            if (httpSession.getAttribute("error_code") == "5") {
        %>     
        <script>
            window.alert("Please check your username and passoword.");
        </script>
        <%
            }


        %>

        <script>
            function loginvalidate() {
                var username1 = document.login.username.value;
                var password1 = document.login.password.value;

                if (username1.length == 0) {
                    document.getElementById("vali_username1").innerHTML = "Please enter your username.";
                } else {
                    document.getElementById("vali_username1").innerHTML = "";
                }

                if (password1.length == 0) {
                    document.getElementById("vali_password1").innerHTML = " Please enter your password.";
                } else {
                    document.getElementById("vali_password1").innerHTML = "";
                }


            }
            function registerValidate() {
                var username = document.register.username.value;
                var email = document.register.email.value;
                var password = document.register.password.value;
                var mailformat = /^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/;
                if (username.length == 0) {
                    document.getElementById("vali_username").innerHTML = "Please enter your username.";
                } else {
                    document.getElementById("vali_username").innerHTML = "";
                }

                if (email.length == 0) {
                    document.getElementById("vali_email").innerHTML = "Please enter your email address.";
                } else if (!email.match(mailformat)) {
                    document.getElementById("vali_email").innerHTML = "Please enter a valid email address.";
                } else {
                    document.getElementById("vali_email").innerHTML = "";
                }
                if (password.length == 0) {
                    document.getElementById("vali_password").innerHTML = " Please enter your password.";
                } else if (password.length < 6) {
                    document.getElementById("vali_password").innerHTML = "  Password should have at least six characters.";
                } else {
                    document.getElementById("vali_password").innerHTML = "";
                }


            }

           





        </script>
    </body>
</html>
