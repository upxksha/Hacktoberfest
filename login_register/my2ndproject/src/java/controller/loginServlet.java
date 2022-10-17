/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package controller;

import java.io.IOException;
import java.io.PrintWriter;
import javax.servlet.ServletException;
import javax.servlet.http.Cookie;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;
import model.user;

/**
 *
 * @author DELL
 */
public class loginServlet extends HttpServlet {

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
            out.println("<title>Servlet loginServlet</title>");
            out.println("</head>");
            out.println("<body>");
            out.println("<h1>Servlet loginServlet at " + request.getContextPath() + "</h1>");
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
        String username_u = null;
        String password_p = null;
        username_u = request.getParameter("username");
        password_p = request.getParameter("password");

        if (username_u.equals("") || password_p.equals("")) {
            response.sendRedirect("index.jsp");
        } else {
            user User = new user();
            HttpSession httpSession = request.getSession();

            User.setUsername(username_u);
            User.setPassword(password_p);

            userlogin UserLogin = new userlogin();

            switch (UserLogin.userlogin(User)) {
                case 4:

                    Cookie cookie_array[] = request.getCookies();
                    int sess_id = User.getSessionid();

                    for (Cookie c : cookie_array) {
                        if (c.getName().equals("session_id")) {
                            c.setValue(sess_id + "");
                            c.setMaxAge(60 * 60);
                            response.addCookie(c);
                        } else {
                            Cookie cookiei1 = new Cookie("session_id", sess_id + "");
                            cookiei1.setMaxAge(60 * 60);
                            response.addCookie(cookiei1);

                        }
                    }

                    httpSession.setAttribute("error_code", "4");
                    response.sendRedirect("info.jsp");
                    break;
                case 5:
                    httpSession.setAttribute("error_code", "5");
                    response.sendRedirect("index.jsp");
                    break;
                default:
                    httpSession.setAttribute("error_code", "6");
                    response.sendRedirect("index.jsp");
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
