/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Models;

import java.awt.Color;
import java.awt.Graphics2D;

/**
 * Gates that open and close
 *
 * @author Stefan
 */
public class Gate extends Wall implements Runnable {

    // Properties
    private boolean open = false;
    private boolean bottom = false;
    private int timer = 0;

    // Constructor
    /**
     *
     * @param topLeftX top left x coordinate
     * @param topLeftY top left y coordinate
     * @param width with in pixels
     * @param height height in pixels
     * @param color color of the gate
     * @param bgColor background color of the canvas
     * @param canvas canvas that the gate will be drawn on
     */
    public Gate(int topLeftX, int topLeftY, int width, int height, Color color, Color bgColor, Graphics2D canvas) {
        super(topLeftX, topLeftY, width, height, color, bgColor, canvas);
    }

    // Methods
    @Override
    public void run() {
        while (true) {
            draw();
            if (timer == 10) {
                timer = 0;
                toggleOpenClose();
            } else {
                timer++;
            }
        }
    }

    /**
     * opens the gate if it is closed and closes the gate if it is open
     */
    private void toggleOpenClose() {
        if (open) {
            close();
        } else {
            open();
        }
        int temp = height;
        height = width;
        width = temp;
    }

    /**
     * opens the gate
     */
    private void open() {
        topLeftX -= height;
        if (!bottom) {
            topLeftY -= width;
        } else {
            topLeftY += height;
        }
        open = true;
    }

    /**
     * closes the gate
     */
    private void close() {
        topLeftX += width;
        if (bottom) {
            topLeftY -= width;
        } else {
            topLeftY += height;
        }
        open = false;
    }

    // Setters and Getters
    public void setBottom(boolean bottom) {
        this.bottom = bottom;
    }

}
