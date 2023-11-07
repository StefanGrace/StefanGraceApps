/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package calculator;

/**
 *
 * @author Stefan
 */
public class Calculator {

    private String display = "0";
    private double value = 0.0;
    private String operation = "none";
    private boolean toClear = true;

    public void calculate() {
        toClear = true;
        double previosValue = value;
        try {
            value = Double.parseDouble(display);
        } catch (NumberFormatException e) {
        }
        switch (operation) {
            case "plus":
                value += previosValue;
                operation = "none";
                break;
            case "minus":
                value = previosValue - value;
                operation = "none";
                break;
            case "times":
                value *= previosValue;
                operation = "none";
                break;
            case "divide":
                value = previosValue / value;
                operation = "none";
                break;
        }
        display = Double.toString(value);
        if (display.endsWith(".0")) {
            display = display.substring(0, display.length() - 2);
        }
    }

    public void plus() {
        calculate();
        operation = "plus";
    }

    public void minus() {
        calculate();
        operation = "minus";
    }

    public void times() {
        calculate();
        operation = "times";
    }

    public void divide() {
        calculate();
        operation = "divide";
    }

    public void clear() {
        display = "0";
    }

    public void sqrt() {
        try {
            value = Double.parseDouble(display);
        } catch (NumberFormatException e) {
        }
        value = Math.sqrt(value);
        display = Double.toString(value);
    }

    public void pi() {
        display = Double.toString(Math.PI);
    }

    public void plusMinus() {
        if (!display.startsWith("-")) {
            display = "-" + display;
        } else {
            display = display.substring(1);
        }
    }

    public void addDigit(String digit) {
        if (toClear) {
            display = "";
            toClear = false;
        }
        if (digit.equals(".") && display.equals("")) {
            display += "0";
        }
        display += digit;
    }

    public String getDisplay() {
        return display;
    }
}
