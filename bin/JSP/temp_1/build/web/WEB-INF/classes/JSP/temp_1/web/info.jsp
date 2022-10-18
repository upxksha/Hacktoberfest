<%-- 
    Document   : index
    Created on : Aug 25, 2022, 11:42:39 AM
    Author     : dhanu
--%>

<%@page import="java.sql.ResultSet" %>
<%@page import="java.sql.Statement" %>
<%@page import="java.sql.Connection" %>
<%@page import="Controller.DBConnection" %>
<%@page contentType="text/html" pageEncoding="UTF-8" %>
<!DOCTYPE html>
<html>

    <head>
        <meta charset="UTF-8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <meta http-equiv="X-UA-Compatible" content="ie=edge">
        <title>User Details</title>

        <!-- Font Icon -->
        <link rel="stylesheet" href="fonts/material-icon/css/material-design-iconic-font.min.css">

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

            if (sessionId == 0) {
                response.sendRedirect("index.jsp");
            }
        %>
        <div class="main">
            <!-- Sign up form -->
            <section class="signup">
                <div class="container">
                    <div class="signup-content">
                        <div class="signup-form">
                            <center>
                                <div style="margin-left: 200px;">
                                    <h2 class="form-title">User Details</h2>
                            </center>
                            <% DBConnection dBConnection = new DBConnection();
                                Connection connection = dBConnection.getConnection();

                            %>

                            <% try {
                                    Statement statement = connection.createStatement();
                                    ResultSet resultSet = statement.executeQuery("SELECT * FROM tutorial.user WHERE session_id = " + sessionId + " ");

                                    resultSet.next();
                            %>

                            <h3>User Id: <i style="padding-left: 55px; color: red"><%=resultSet.getInt(1)%>
                                </i></h3>
                            <h3>User Name: <i style="padding-left: 20px; color: red"><%=resultSet.getString(2)%>
                                </i></h3>
                            <h3>User Age: <i style="padding-left: 35px; color: red"><%=resultSet.getInt(3)%>
                                </i></h3>
                            <h3>User Email:<i style="padding-left: 20px; color: red"><%=resultSet.getString(4)%>
                                </i></h3>

                            <%
                                } catch (Exception e) {
                                    out.print(e.getMessage());
                                }

                            %>

                            <div class="form-group form-button" style="margin-top: 80px">
                                <a href="./UserLogOutServlet?id=<%=sessionId%>">
                                    <input type="submit" name="signin" id="signin" class="form-submit" value="Log Out" style="background-color: red"/>
                                </a>
                            </div>
                        </div>


                    </div>

                </div>
        </div>
    </section>
</div>

<!-- JS -->
<script src="vendor/jquery/jquery.min.js"></script>
<script src="js/main.js"></script>
</html>
