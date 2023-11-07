/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package zerodividedbyzero;

/**
 *
 * @author Stefan
 */
public class ZeroDividedByZero {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        
        System.out.print("Int: ");
        int zero = 0;
        try {
            System.out.println(zero / zero);
        } catch (Exception e){
            System.out.println(e.getMessage());
        }
        
        System.out.print("Float: ");
        System.out.println(0.0 / 0.0);
    }
    
}
