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
public class ARRAY {
    public int sumArray(int size){
         int [] array = new int [size];
	 Scanner objScan = new Scanner(System.in);
	        for(int i=0;i<size;i++)
	        {
	            System.out.println("Enter value : ");
	            array[i]=objScan.nextInt();
                    
	        }
               return array[0]+array[size-1];
                

    }
}
