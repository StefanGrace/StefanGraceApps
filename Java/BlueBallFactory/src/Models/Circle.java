/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Models;

import java.awt.Color;
import java.awt.Graphics2D;

/**
 * Circle shape
 * @author Stefan
 */
public class Circle extends Shape implements IMoveAndDraw, Runnable {

    //Properties
    private int radius;

    //To stop thread
    private volatile boolean exit = false;
    //Constructor
    /**
     *
     * @param topLeftX the x coordinate of the top left of the circle
     * @param topLeftY the y coordinate of the top left of the circle
     * @param radius the radius of the circle
     * @param color the color that the circle will be drawn
     * @param canvas the canvas to draw the circle on
     */
    public Circle(int topLeftX, int topLeftY, int radius, Color color, Graphics2D canvas) {
        super(topLeftX, topLeftY, 1, 1, color, canvas);
        this.width = 2 * radius;
        this.height = 2 * radius;
        this.radius = radius;
    }

    //Methods
    @Override
    public String toString() {
        return "Circle: " + super.toString();
    }

    public int getRadius() {
        return radius;
    }

    /////////////////////////////////
    @Override
    /**
     * moves the circle
     */
    public void move(int speedX, int speedY, int angle) {
        topLeftX += speedX;
        topLeftY += speedY;

        //
        checkBoundaryCollision();

    }

    /**
     * Draws the circle on the canvas
     */
    @Override
    public void draw() {
        //1: call lock() method
        lock.lock();
        try {
            //Draw a circle on canvas
            canvas.setColor(color);
            canvas.fillOval(topLeftX, topLeftY, width, height);
        } catch (Exception e) {

        } finally {
            //call unlock() method
            lock.unlock();
        }

        try {
            //Delay 100ms times the speed of the factory
            Thread.sleep(Math.round((100.0 * (1.0 /speed))));
        } catch (InterruptedException e) {
        }

        //Remove the cicle
        //1: call lock() method
        lock.lock();
        try {
            //Draw a circle on canvas
            canvas.setColor(bgColor);
            canvas.fillOval(topLeftX, topLeftY, width, height);
        } catch (Exception e) {

        } finally {
            //call unlock() method
            lock.unlock();
        }

    }

    
    /**
     * makes the circle bounce of the edges of the canvas
     */
    public void checkBoundaryCollision() {
        //Check if the ball reaches to any bound? If yes, the ball bounces off   
        //Detect the horizontal borders
        if (this.topLeftY < boundary[1]) {
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

    /**
     * runs the circle thread
     */
    @Override
    public void run() {
        while (!exit) {
            move(speedX, speedY, angle);
            draw();
        }
    }

    /**
     * stops the circle thread
     */
    @Override
    public void stop() {
        exit = true;
    }
}
