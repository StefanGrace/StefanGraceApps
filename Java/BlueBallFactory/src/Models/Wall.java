/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Models;

import java.awt.Color;
import java.awt.Graphics2D;

/**
 * Wall that the shapes bounce off
 *
 * @author Stefan
 */
public class Wall extends FactoryComponent implements Runnable {

    // Properties
    protected int topLeftX;
    protected int topLeftY;
    protected int width;
    protected int height;

    // Constructor
    /**
     *
     * @param topLeftX the top left x coordinate
     * @param topLeftY the top left y coordinate
     * @param width width in pixels
     * @param height height in pixels
     * @param color the color of the wall
     * @param bgColor the background color behind the wall
     * @param canvas the canvas that the wall will be drawn on
     */
    public Wall(int topLeftX, int topLeftY, int width, int height, Color color, Color bgColor, Graphics2D canvas) {
        super(color, bgColor, canvas);
        this.topLeftX = topLeftX;
        this.topLeftY = topLeftY;
        this.width = width;
        this.height = height;
    }

    // Methods
    @Override
    public void draw() {
        //1: call lock() method
        lock.lock();
        try {
            //Draw on canvas
            canvas.setColor(color);
            canvas.fillRect(topLeftX, topLeftY, width, height);
        } catch (Exception e) {

        } finally {
            //call unlock() method
            lock.unlock();
        }

        try {
            //Delay 100ms times the speed of the factory
            Thread.sleep(Math.round((100.0 * (1.0 / speed))));
        } catch (InterruptedException e) {
        }

        //Remove 
        //call lock() method
        lock.lock();
        try {
            canvas.setColor(bgColor);
            canvas.fillRect(topLeftX, topLeftY, width, height);
        } catch (Exception e) {

        } finally {
            //call unlock() method
            lock.unlock();
        }
    }

    @Override
    public void run() {
        while (true) {
            draw();
        }
    }

    // Getters and Setters
    public int getTopLeftX() {
        return topLeftX;
    }

    public void setTopLeftX(int topLeftX) {
        this.topLeftX = topLeftX;
    }

    public int getTopLeftY() {
        return topLeftY;
    }

    public void setTopLeftY(int topLeftY) {
        this.topLeftY = topLeftY;
    }

    public int getWidth() {
        return width;
    }

    public void setWidth(int width) {
        this.width = width;
    }

    public int getHeight() {
        return height;
    }

    public void setHeight(int height) {
        this.height = height;
    }

}
