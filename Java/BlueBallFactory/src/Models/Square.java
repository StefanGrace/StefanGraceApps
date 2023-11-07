/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Models;

import java.awt.Color;
import java.awt.Graphics2D;

/**
 * Square shape
 * @author Stefan
 */
public class Square extends Shape implements Runnable, IMoveAndDraw {

    // Properties
    //To stop thread
    private volatile boolean exit = false;

    //Constructor
    /**
     *
     * @param topLeftX the top left x coordinate
     * @param topLeftY the top left y coordinate
     * @param widthHeight the width and height are both the same because it's a square
     * @param color the color of the rectangle
     * @param canvas the canvas that the rectangle will be drawn on
     */
    public Square(int topLeftX, int topLeftY, int widthHeight, Color color, Graphics2D canvas) {
        super(topLeftX, topLeftY, widthHeight, widthHeight, color, canvas);
    }

    //Methods
    @Override
    public String toString() {
        return "Rectangle: " + super.toString();
    }


    @Override
    public void move(int speedX, int speedY, int angle) {
        topLeftX += speedX;
        topLeftY += speedY;

        //
        checkBoundaryCollision();

    }

    @Override
    public void draw() {
        //1: call lock() method
        lock.lock();
        try {
            //Draw a square on canvas
            canvas.setColor(color);
            canvas.fillRect(topLeftX, topLeftY, width, height);
        } catch (Exception e) {

        } finally {
            //call unlock() method
            lock.unlock();
        }

        //Wait 100ms
        try {
            //Delay 100ms
            Thread.sleep(Math.round((100.0 * (1.0 /speed))));
        } catch (InterruptedException e) {
        }

        //Remove the cicle
        //1: call lock() method
        lock.lock();
        try {
            //Draw a circle on canvas
            canvas.setColor(bgColor);
            canvas.fillRect(topLeftX, topLeftY, width, height);
        } catch (Exception e) {

        } finally {
            //call unlock() method
            lock.unlock();
        }
    }

    /**
     * makes the rectangle bounce of the edges of the canvas
     */
    public void checkBoundaryCollision() {
        //Check if the ball reaches to any bound? If yes, the ball bounces off   
        //Detect the horizontal borders
        if (boundary[1] >= topLeftY) {
            //Top border
            speedY = -speedY;
            topLeftY = boundary[1];
        } else if (topLeftY + height > boundary[3]) {
            //Bottom border
            speedY = -speedY;
            topLeftY = boundary[3] - height;
        }

        //Detect the vertical borders
        if (topLeftX < boundary[0]) {
            //Left border
            speedX = -speedX;
            topLeftX = boundary[0];
        } else if (topLeftX + width > boundary[2]) {
            //Right border
            speedX = -speedX;
            topLeftX = boundary[2] - width;
        }
    }
    ////////////////////////////////////

    @Override
    public void run() {
        while (!exit) {
            move(speedX, speedY, angle);
            draw();
        }
    }

    //stop() method
    @Override
    public void stop() {
        exit = true;
    }
}
