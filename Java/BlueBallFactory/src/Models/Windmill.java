/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Models;

import java.awt.Color;
import java.awt.Graphics2D;

/**
 * Windmill that the shapes change direction when they hit
 *
 * @author Stefan
 */
public class Windmill extends FactoryComponent implements Runnable {

    // Properties
    private int[] arrayX, arrayY, rotatedArrayX, rotatedArrayY = new int[12];
    private int centerX, centerY;
    private int rotationTimer = 0;
    private boolean rotated = false;

    // Constructor
    /**
     *
     * @param arrayX an array of the x coordinates of the points
     * @param arrayY an array of the y coordinates of the points
     * @param rotatedArrayX an array of the alternate x coordinates of the
     * points
     * @param rotatedArrayY an array of the alternate y coordinates of the
     * points
     * @param centerX the x coordinate of the center of the wind mill
     * @param centerY the y coordinate of the center of the wind mill
     * @param color the color that the windmill shall be drawn
     * @param bgColor the background color of the canvas
     * @param canvas the canvas for the windmill to be drawn on
     */
    public Windmill(int[] arrayX, int[] arrayY, int[] rotatedArrayX, int[] rotatedArrayY, int centerX, int centerY, Color color, Color bgColor, Graphics2D canvas) {
        super(color, bgColor, canvas);
        this.arrayX = arrayX;
        this.arrayY = arrayY;
        this.rotatedArrayX = rotatedArrayX;
        this.rotatedArrayY = rotatedArrayY;
        this.centerX = centerX;
        this.centerY = centerY;
    }

    // Methods
    @Override
    public void run() {
        while (true) {
            draw();
            if (rotationTimer == 5) {
                rotationTimer = 0;
                rotate();
            } else {
                rotationTimer++;
            }

        }
    }

    @Override
    public void draw() {
        lock.lock();
        try {
            //Draw shape on canvas
            canvas.setColor(color);
            canvas.fillPolygon(arrayX, arrayY, 12);
        } catch (Exception e) {
        } finally {
            //call unlock() method
            lock.unlock();
        }

        //Wait 500ms
        try {
            //Delay 500ms
            Thread.sleep(Math.round((100.0 * (1.0 / speed))));
        } catch (InterruptedException ex) {
        }

        //Remove the windmill
        //1: call lock() method
        lock.lock();
        try {
            canvas.setColor(bgColor);
            canvas.fillPolygon(arrayX, arrayY, 12);
        } catch (Exception e) {
        } finally {
            //call unlock() method
            lock.unlock();
        }
    }

    /**
     * Alternates the windmill between a '+' shape and a 'X' shape
     */
    private void rotate() {
        int[] tempX = arrayX;
        int[] tempY = arrayY;
        arrayX = rotatedArrayX;
        arrayY = rotatedArrayY;
        rotatedArrayX = tempX;
        rotatedArrayY = tempY;
        rotated = !rotated;
    }

    // Setters and Getters
    public int[] getArrayX() {
        return arrayX;
    }

    public void setArrayX(int[] arrayX) {
        this.arrayX = arrayX;
    }

    public int[] getArrayY() {
        return arrayY;
    }

    public void setArrayY(int[] arrayY) {
        this.arrayY = arrayY;
    }

    public int[] getRotatedArrayX() {
        return rotatedArrayX;
    }

    public void setRotatedArrayX(int[] rotatedArrayX) {
        this.rotatedArrayX = rotatedArrayX;
    }

    public int[] getRotatedArrayY() {
        return rotatedArrayY;
    }

    public void setRotatedArrayY(int[] rotatedArrayY) {
        this.rotatedArrayY = rotatedArrayY;
    }

    public int getCenterX() {
        return centerX;
    }

    public void setCenterX(int centerX) {
        this.centerX = centerX;
    }

    public int getCenterY() {
        return centerY;
    }

    public void setCenterY(int centerY) {
        this.centerY = centerY;
    }

    public boolean isRotated() {
        return rotated;
    }

    public int getWidth() {
        //return arrayX[3] - arrayX[10];
        return 110;
    }

    public int getHeight() {
        //return arrayY[7] - arrayY[0];
        return 110;
    }

}
