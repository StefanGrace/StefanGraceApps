/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package MainPackage;

/**
 *
 * @author Stefan
 */
public class Converter {
    public String convert(double inputValue, String inputUnit, String outputUnit) {
        return "" + ((inputValue * unitToMultiplier(inputUnit)) / unitToMultiplier(outputUnit));
    }
    
    private double unitToMultiplier(String unit) {
        switch (unit) {
            case "b": return 1; 
            case "B": return 8;
            // k
            case "kb": return Math.pow(10, 3);
            case "Kib": return Math.pow(2, 10);
            case "kB": return Math.pow(10, 3) * 8;
            case "KiB": return Math.pow(2, 10) * 8;
            // M 
            case "Mb": return Math.pow(10, 6);
            case "Mib": return Math.pow(2, 20);
            case "MB": return Math.pow(10, 6) * 8;
            case "MiB": return Math.pow(2, 20) * 8;
            // G 
            case "Gb": return Math.pow(10, 9);
            case "Gib": return Math.pow(2, 30);
            case "GB": return Math.pow(10, 9) * 8;
            case "GiB": return Math.pow(2, 30) * 8;
            // T 
            case "Tb": return Math.pow(10, 12);
            case "Tib": return Math.pow(2, 40);
            case "TB": return Math.pow(10, 12) * 8;
            case "TiB": return Math.pow(2, 40) * 8;
            // P
            case "Pb": return Math.pow(10, 15);
            case "Pib": return Math.pow(2, 50);
            case "PB": return Math.pow(10, 15) * 8;
            case "PiB": return Math.pow(2, 50) * 8;
            // E
            case "Eb": return Math.pow(10, 18);
            case "Eib": return Math.pow(2, 60);
            case "EB": return Math.pow(10, 18) * 8;
            case "EiB": return Math.pow(2, 60) * 8;
            // Z
            case "Zb": return Math.pow(10, 21);
            case "Zib": return Math.pow(2, 70);
            case "ZB": return Math.pow(10, 21) * 8;
            case "ZiB": return Math.pow(2, 70) * 8;
            // Y
            case "Yb": return Math.pow(10, 24);
            case "Yib": return Math.pow(2, 80);
            case "YB": return Math.pow(10, 24) * 8;
            case "YiB": return Math.pow(2, 80) * 8;
            
        }
        return 0.0;
    }
}
