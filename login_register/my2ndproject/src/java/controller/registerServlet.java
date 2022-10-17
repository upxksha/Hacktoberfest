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
public class registerServlet extends HttpServlet {

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
            out.println("<title>Servlet registerServlet</title>");            
            out.println("</head>");
            out.println("<body>");
            out.println("<h1>Servlet registerServlet at " + request.getContextPath() + "</h1>");
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
        /*String full_name = request.getParameter("name");*/
        String email = request.getParameter("email");
        String username_u = request.getParameter("username");
        String password = request.getParameter("password");

        user User = new user();
        HttpSession httpSession = request.getSession();
        userRegister UserRegister = new userRegister();

        /*User.setFullname(full_name);*/
        User.setEmail(email);
        User.setUsername(username_u);
        User.setPassword(password);

        if (UserRegister.userRegister(User) == 1) {
            httpSession.setAttribute("error_code", "1");

            Cookie cookie_array[] = request.getCookies();
            int sess_id = User.getSessionid();
            String sess_name = User.getSessionname();

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

            response.sendRedirect("info.jsp");

        } else if (UserRegister.userRegister(User) == 2) {
            httpSession.setAttribute("error_code", "2");
            response.sendRedirect("index.jsp");
        } else {
            httpSession.setAttribute("error_code", "3");
            response.sendRedirect("index.jsp");
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
