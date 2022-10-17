/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package project2;
import java.util.Scanner;
/**
 *
 * @author DELL
 */
public class Project2 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
       /* MyNewClass objClass = new MyNewClass();
        
        objClass.PrintHelloWorld();
        
         MySecondClass objclass2 = new MySecondClass();
        
        objclass2.printinfo();
        
        sumClass objClass1 = new sumClass();
        objClass1.printSum();
        
        divisible objClass3 = new divisible();
        objClass3.printdivisible();*/
        
    Scanner objScan = new Scanner(System.in);
    
        System.out.println("Enter age :");
         int age = objScan.nextInt();
          
        voting objclass4 = new voting();
        objclass4.checkvoting(age);
        
        System.out.println("Enter the number 1 : ");
        int n1 = objScan.nextInt();
        
        System.out.println("Enter the number 2 : ");
        int n2 = objScan.nextInt();
        
        maxValue objClass5 = new maxValue();
        int max = objClass5.returnMax(n1, n2);
        System.out.println("Answer is "+max);
     
        
        System.out.println("Enter the size of the array : ");
        int size = objScan.nextInt();
        
        ARRAY objClass6 = new ARRAY();
        int sum =objClass6.sumArray(size);
        System.out.println("Summation  is "+sum);
    }
    
  
    
}
