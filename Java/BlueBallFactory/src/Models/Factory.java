/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Models;

import java.awt.Color;
import java.awt.Graphics2D;
import java.util.ArrayList;
import java.util.concurrent.locks.Lock;
import java.util.concurrent.locks.ReentrantLock;

/**
 * This class contains the all the shapes and factory items and runs the factory
 * logic
 *
 * @author Stefan
 */
public class Factory {

    // Properties
    private Color bgColor;
    private final Graphics2D canvas;
    private final int canvasWidth;
    private final int canvasHeight;
    private double speed = 1.0;

    // Item arrays
    private final ArrayList<Shape> circles = new ArrayList<>();
    private final ArrayList<Shape> squares = new ArrayList<>();

    // Factory Components
    private Pipe pipe;
    private Windmill wm;
    private Wall wall1, wall2;
    private Gate topGate, bottomGate;
    private CollisionHandler collisonHandler;

    // Lock
    private final Lock masterLock = new ReentrantLock();

    // Constructor
    /**
     *
     * @param canvas canvas for factory items and shapes to be drawn on
     * @param canvasWidth with of the canvas in pixels
     * @param canvasHeight height of the canvas in pixels
     * @param bgColor the background color of the canvas
     */
    public Factory(Graphics2D canvas, int canvasWidth, int canvasHeight, Color bgColor) {
        this.canvas = canvas;
        this.canvasWidth = canvasWidth;
        this.canvasHeight = canvasHeight;
        this.bgColor = bgColor;
        generateFactoryComponents();
    }

    // Methods
    /**
     * Adds a blue circle to the factory at the pipe, moving in a random
     * direction
     */
    public void createCircle() {
        CreateShape.createCircle(circles, canvas, canvasWidth, canvasHeight, bgColor, speed, masterLock);
    }

    /**
     * Adds a red square to the factory at the pipe, moving in a random
     * direction
     */
    public void createSquare() {
        CreateShape.createSquare(squares, canvas, canvasWidth, canvasHeight, bgColor, speed, masterLock);
    }

    /**
     * Removes all blue circles and red squares form the factory
     */
    public void removeItems() {
        //stop all circle threads.
        circles.forEach((circle) -> {
            circle.stop();
        });
        //stop all square threads.
        squares.forEach((square) -> {
            square.stop();
        });
    }

    /**
     * Creates the pipe, windmill, walls, gates and starts the collision handler
     * thread
     */
    private void generateFactoryComponents() {

        // Pipe
        pipe = new Pipe(100, canvas);
        pipe.setLock(masterLock);
        Thread pipeThread = new Thread(pipe);
        pipeThread.start();

        // Windmill
        int[] arrayX = {118, 148, 148, 213, 213, 148, 148, 118, 118, 53, 53, 118}; // set the starting x cooridinates of the windmill
        int[] arrayY = {160, 160, 225, 225, 255, 255, 320, 320, 255, 255, 225, 225}; // set the starting y cooridinates of the windmill
        int[] rotatedArrayX = {87, 133, 179, 200, 155, 200, 179, 133, 87, 66, 112, 66}; // set the rotated x cooridinates of the windmill
        int[] rotatedArrayY = {174, 219, 174, 195, 240, 285, 307, 262, 307, 286, 240, 194}; // set the rotated y cooridinates of the windmill
        wm = new Windmill(arrayX, arrayY, rotatedArrayX, rotatedArrayY, 240, 214, new Color(0, 0, 0), bgColor, canvas);
        wm.setLock(masterLock);
        Thread wmThread = new Thread(wm);
        wmThread.start();

        // Walls
        wall1 = new Wall(656, 0, 30, 80, new Color(0, 0, 0), bgColor, canvas);
        wall2 = new Wall(656, 400, 30, 80, new Color(0, 0, 0), bgColor, canvas);
        Thread wall1Thread = new Thread(wall1);
        Thread wall2Thread = new Thread(wall2);
        wall1.setLock(masterLock);
        wall2.setLock(masterLock);
        wall1Thread.start();
        wall2Thread.start();

        // Gates
        topGate = new Gate(656, 80, 30, 160, new Color(128, 128, 128), bgColor, canvas);
        bottomGate = new Gate(656, 240, 30, 160, new Color(128, 128, 128), bgColor, canvas);
        bottomGate.setBottom(true);
        topGate.setLock(masterLock);
        bottomGate.setLock(masterLock);
        Thread topGateThread = new Thread(topGate);
        Thread bottomGateThread = new Thread(bottomGate);
        topGateThread.start();
        bottomGateThread.start();

        // CollisonHandler
        Wall[] wallAndGate = {wall1, wall2, topGate, bottomGate};
        int[] boundary = {0, 0, canvasWidth, canvasHeight};
        collisonHandler = new CollisionHandler(circles, squares, wallAndGate, wm, canvas, boundary, masterLock, bgColor);
        Thread chThread = new Thread(collisonHandler);
        chThread.start();
    }

    /**
     * Sets the background color of the factory
     *
     * @param bgColor background color
     */
    public void setBgColor(Color bgColor) {
        this.bgColor = bgColor;
        canvas.setColor(bgColor);
        canvas.fillRect(0, 0, canvasWidth, canvasHeight);
        canvas.setBackground(bgColor);
        try {
            wm.setBgColor(bgColor);
            topGate.setBgColor(bgColor);
            bottomGate.setBgColor(bgColor);
            collisonHandler.setBgColor(bgColor);
            for (int i = 0; i < circles.size(); i++) {
                circles.get(i).setBgColor(bgColor);
            }
            for (int i = 0; i < squares.size(); i++) {
                squares.get(i).setBgColor(bgColor);
            }
        } catch (Exception e) {

        }
    }

    /**
     * Sets the speed of the factory
     *
     * @param speed factory speed multiplier
     */
    public void setSpeed(double speed) {
        this.speed = speed;
        try {
            wm.setSpeed(speed);
            topGate.setSpeed(speed);
            bottomGate.setSpeed(speed);
            collisonHandler.setSpeed(speed);
            for (int i = 0; i < circles.size(); i++) {
                circles.get(i).setSpeed(speed);
            }
            for (int i = 0; i < squares.size(); i++) {
                squares.get(i).setSpeed(speed);
            }
        } catch (Exception e) {

        }
    }

}
