/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Models;

import java.awt.Color;
import java.awt.Graphics2D;
import java.util.concurrent.locks.Lock;

/**
 * Pipe that the shapes come out of
 *
 * @author Stefan
 */
public class Pipe extends SpeedControl implements Runnable {

    // Properties
    private final Graphics2D canvas;
    private int width;
    private Lock lock;
    private volatile boolean exit = false;

    // Constructor
    /**
     *
     * @param width the width of the pipe in pixels
     * @param canvas the canvas that the pipe will be drawn on
     */
    public Pipe(int width, Graphics2D canvas) {
        this.canvas = canvas;
        this.width = width;
    }

    // Methods
    /**
     * Draws the pipe onto the canvas
     */
    public void draw() {
        lock.lock();
        try {
            // draw the pipe
            canvas.setColor(new Color(0, 255, 0));
            canvas.fillRect((854 / 2) - (width / 2), 0, width, 30);
            // draw the hole at the end of the pipe
            canvas.setColor(new Color(0, 128, 0));
            canvas.fillOval((854 / 2) - (width / 2), 20, width, 20);
        } catch (Exception e) {

        } finally {
            lock.unlock();
        }

        try {
            //Delay 100ms times the speed of the factory
            Thread.sleep(Math.round((100.0 * (1.0 / speed))));
        } catch (InterruptedException ex) {
        }

    }

    @Override
    public void run() {
        while (!exit) {
            draw();
        }
    }

    //Setters and Getters
    public int getWidth() {
        return width;
    }

    public void setWidth(int width) {
        this.width = width;
    }

    public Lock getLock() {
        return lock;
    }

    public void setLock(Lock lock) {
        this.lock = lock;
    }

}
