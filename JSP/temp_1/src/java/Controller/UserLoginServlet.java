/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Controller;

import Model.User;
import java.io.IOException;
import java.io.PrintWriter;
import javax.servlet.ServletException;
import javax.servlet.http.Cookie;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;

/**
 *
 * @author dhanu
 */
public class UserLoginServlet extends HttpServlet {

    /**
     * Processes requests for both HTTP <code>GET</code> and <code>POST</code>
     * methods.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    protected void processRequest(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        response.setContentType("text/html;charset=UTF-8");
        try (PrintWriter out = response.getWriter()) {
            /* TODO output your page here. You may use following sample code. */
            out.println("<!DOCTYPE html>");
            out.println("<html>");
            out.println("<head>");
            out.println("<title>Servlet UserLoginServlet</title>");
            out.println("</head>");
            out.println("<body>");
            out.println("<h1>Servlet UserLoginServlet at " + request.getContextPath() + "</h1>");
            out.println("</body>");
            out.println("</html>");
        }
    }

    // <editor-fold defaultstate="collapsed" desc="HttpServlet methods. Click on the + sign on the left to edit the code.">
    /**
     * Handles the HTTP <code>GET</code> method.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    @Override
    protected void doGet(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        processRequest(request, response);
    }

    /**
     * Handles the HTTP <code>POST</code> method.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    @Override
    protected void doPost(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        HttpSession httpSession = request.getSession();

        String email = null;
        String password = null;
        email = request.getParameter("email");
        password = request.getParameter("password");

        if (email.equals("") || password.equals("")) {
            response.sendRedirect("info.jsp");
        } else {
            User user = new User();
            user.setEmail(email);
            user.setPassword(password);

            UserLogin userLogin = new UserLogin();
            switch (userLogin.userLogin(user)) {
                case 0:
                    int sessionId = user.getSessionId();
                    Cookie cookies[] = request.getCookies();

                    for (Cookie c : cookies) {
                        if (c.getName().equals("session_id")) {
                            c.setValue(sessionId + "");
                            c.setMaxAge(60 * 60);
                            response.addCookie(c);
                        } else {
                            Cookie sesId = new Cookie("session_id", sessionId + "");
                            sesId.setMaxAge(60 * 60);
                            response.addCookie(sesId);
                        }
                    }

                    httpSession.setAttribute("error_code", "0");
                    response.sendRedirect("info.jsp");
                    break;
                case 1:
                    // Username and password are incorrect
                    httpSession.setAttribute("error_code", "1");
                    response.sendRedirect("index.jsp");
                    break;
                case 2:
                    // user.setError(2);
                    httpSession.setAttribute("error_code", "2");
                    response.sendRedirect("index.jsp");
                    break;
                default:
                    break;
            }
        }

    }

    /**
     * Returns a short description of the servlet.
     *
     * @return a String containing servlet description
     */
    @Override
    public String getServletInfo() {
        return "Short description";
    }// </editor-fold>

}
