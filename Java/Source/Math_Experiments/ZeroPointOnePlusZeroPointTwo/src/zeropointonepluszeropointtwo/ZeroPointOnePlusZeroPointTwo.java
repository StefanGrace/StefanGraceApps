/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package zeropointonepluszeropointtwo;

import java.math.BigDecimal;

/**
 *
 * @author Stefan
 */
public class ZeroPointOnePlusZeroPointTwo {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        
        System.out.println("64-bit binary float:");
        System.out.println("0.1 + 0.2 = " + String.format("%.17f", 0.1 + 0.2));
        System.out.println("0.1 + 0.2 == 0.3? " + (0.1 + 0.2 == 0.3));
        System.out.println();
        System.out.println("32-bit binary float:");
        System.out.println("0.1 + 0.2 = " + String.format("%.17f", 0.1f + 0.2f));
        System.out.println("0.1 + 0.2 == 0.3? " + (0.1f + 0.2f == 0.3f));
        System.out.println();
        System.out.println("Decimal:");
        System.out.println("0.1 + 0.2 = " + (new BigDecimal("0.1").add(new BigDecimal("0.2"))).toString());
        System.out.println("0.1 + 0.2 == 0.3? " + ((new BigDecimal("0.1").add(new BigDecimal("0.2"))).compareTo(new BigDecimal("0.3")) == 0));
        
    }
    
}
