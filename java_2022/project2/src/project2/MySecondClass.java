/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package project2;
import java.util.Scanner;

/**
 *
 * @author DELL
 */
public class MySecondClass {
    public void printinfo(){
        Scanner objScan = new Scanner(System.in);
        
        System.out.println("Enter your name : ");
        String Name = objScan.next();
        
         System.out.println("Enter your age : ");
        int age = objScan.nextInt();
        
        System.out.println("Hello,"+Name);
        System.out.println("You are "+age+" old");
      
}
}
