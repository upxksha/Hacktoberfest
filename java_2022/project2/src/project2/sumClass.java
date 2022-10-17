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
public class sumClass {
    public void printSum(){
        Scanner objScan = new Scanner(System.in);
        
        System.out.println("Enter the number 1 : ");
        int num1 = objScan.nextInt();
        
        System.out.println("Enter the number 2 : ");
        int num2 = objScan.nextInt();
        
        System.out.println("The summation is "+(num1+num2));
    }
}
