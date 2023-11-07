/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package numberbaseconverter;

/**
 *
 * @author Stefan
 */
public class NumberBaseConverter {

    int value = 0;
    
    public void update(String value, int base) {
        this.value = Integer.parseInt(value, base);
    }
    
    public String getValue(int base) {
        return Integer.toString(value, base);
    }
    
}
