<%-- 
    Document   : info
    Created on : Sep 1, 2022, 9:52:09 PM
    Author     : DELL
--%>

<%@page import="java.sql.ResultSet"%>
<%@page import="java.sql.Statement"%>
<%@page import="java.sql.Connection"%>
<%@page import="controller.DBconnection"%>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>Information</title>
        <style>
            body {
                align-items: center;
                background-color: #000;
                display: flex;
                justify-content: center;
                height: 100vh;
            }

            .form {
                background-color: #15172b;
                border-radius: 20px;
                box-sizing: border-box;
                height: 500px;
                padding: 20px;
                width: 320px;
            }

            .title {
                color: #eee;
                font-family: sans-serif;
                font-size: 36px;
                font-weight: 600;
                margin-top: 30px;
            }

            .subtitle {
                color: #eee;
                font-family: sans-serif;
                font-size: 16px;
                font-weight: 600;
                margin-top: 10px;
            }

            .input-container {
                height: 50px;
                position: relative;
                width: 100%;
            }

            .ic1 {
                margin-top: 40px;
            }

            .ic2 {
                margin-top: 30px;
            }

            .input {
                background-color: #303245;
                border-radius: 12px;
                border: 0;
                box-sizing: border-box;
                color: #eee;
                font-size: 18px;
                height: 100%;
                outline: 0;
                padding: 4px 20px 0;
                width: 100%;
            }

            .cut {
                background-color: #15172b;
                border-radius: 10px;
                height: 20px;
                left: 20px;
                position: absolute;
                top: -20px;
                transform: translateY(0);
                transition: transform 200ms;
                width: 76px;
            }

            .cut-short {
                width: 50px;
            }

            .input:focus ~ .cut,
            .input:not(:placeholder-shown) ~ .cut {
                transform: translateY(8px);
            }

            .placeholder {
                color: #65657b;
                font-family: sans-serif;
                left: 20px;
                line-height: 14px;
                pointer-events: none;
                position: absolute;
                transform-origin: 0 50%;
                transition: transform 200ms, color 200ms;
                top: 20px;
            }

            .input:focus ~ .placeholder,
            .input:not(:placeholder-shown) ~ .placeholder {
                transform: translateY(-30px) translateX(10px) scale(0.75);
            }

            .input:not(:placeholder-shown) ~ .placeholder {
                color: #808097;
            }

            .input:focus ~ .placeholder {
                color: #dc2f55;
            }

            .submit {
                background-color: red;
                border-radius: 12px;
                border: 0;
                box-sizing: border-box;
                color: #eee;
                cursor: pointer;
                font-size: 18px;
                height: 50px;
                margin-top: 38px;

                text-align: center;
                width: 100%;
            }

            .submit:active {
                background-color: blue;
            }

        </style>
    </head>
    <body>

        <%

            HttpSession httpSession = request.getSession();

            if (httpSession.getAttribute("error_code") == "1") {
        %>     
        <script>
            window.alert("Registration Sucessfull.....");
        </script>
        <%
            }
            if (httpSession.getAttribute("error_code") == "4") {
        %>     
        <script>
            window.alert("Login Sucessfull.....");
        </script>
        <%
            }
            int sessionid = 0;
            Cookie cookie_array[] = request.getCookies();
            for (Cookie c : cookie_array) {
                if (c.getName().equals("session_id")) {
                    sessionid = Integer.parseInt(c.getValue());
                }
            }
            if (sessionid == 0) {
                response.sendRedirect("index.jsp");
            }
        %>
        <% DBconnection dBConnection = new DBconnection();
            Connection connection = dBConnection.getConnection();


        %>
        <% try {
                Statement statement = connection.createStatement();
                ResultSet resultSet = statement.executeQuery("SELECT * FROM test.user WHERE session_id = " + sessionid + " ");

                resultSet.next();
        %>
        <div class="form">
            <div class="title">Welcome</div>
            <div class="subtitle">Let's create your account!</div>
            <div class="input-container ic1">
                <input id="firstname" class="input" type="text" value="<%=resultSet.getInt(1)%>" readonly/>
                <div class="cut"></div>
                <label for="firstname" class="placeholder">User Id</label>
            </div>
            <div class="input-container ic2">
                <input id="lastname" class="input" type="text" value="<%=resultSet.getString(2)%>" readonly/>
                <div class="cut"></div>
                <label for="lastname" class="placeholder">User Name </label>
            </div>
            <div class="input-container ic2">
                <input id="email" class="input" type="text" value="<%=resultSet.getString(3)%>" readonly/>
                <div class="cut cut-short"></div>
                <label for="email" class="placeholder">Email</label>
            </div>
            <a href = "./logout?id=<%=sessionid%>"> <button type="text" class="submit">Log Out</button></a>
        </div>

        <%
            } catch (Exception e) {
                out.print(e.getMessage());
            }


        %>
    </body>
</html>
