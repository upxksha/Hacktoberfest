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
public class UserInsertServlet extends HttpServlet {

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
            out.println("<title>Servlet UserInsertServlet</title>");
            out.println("</head>");
            out.println("<body>");
            out.println("<h1>Servlet UserInsertServlet at " + request.getContextPath() + "</h1>");
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
        UserRegister userRegister = new UserRegister();
        HttpSession httpSession = request.getSession();

        String name = null;
        String email = null;
        String password = null;

        name = request.getParameter("name");
        int age = Integer.parseInt(request.getParameter("age"));
        email = request.getParameter("email");
        password = request.getParameter("password");

        User user = new User();

        user.setName(name);
        user.setAge(age);
        user.setEmail(email);
        user.setPassword(password);

        switch (userRegister.UserRegister(user)) {
            case 3:
                httpSession.setAttribute("error_code", "3");

                int sessionId = user.getSessionId();
                String sessionName = user.getSessionName();

                Cookie cookies[] = request.getCookies();

                for (Cookie c : cookies) {
                    if (c.getName().equals("session_id")) {
                        c.setValue(sessionId + "");
                        c.setMaxAge(60 * 60);
                        response.addCookie(c);
                    } else {
                        Cookie sesId = new Cookie("session_id", sessionId + "");
                        // Cookie sesName = new Cookie("session_name", sessionName);

                        sesId.setMaxAge(60 * 60);
                        // sesName.setMaxAge(60 * 60);
                        response.addCookie(sesId);
                        // response.addCookie(sesName);
                    }
                }

                response.sendRedirect("info.jsp");
                break;
            case 4:
                httpSession.setAttribute("error_code", "4");
                response.sendRedirect("register.jsp");
                break;
            case 5:
                httpSession.setAttribute("error_code", "5");
                response.sendRedirect("register.jsp");
                break;
            default:
                break;
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
