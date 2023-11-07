/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Models;

import java.awt.Color;
import java.util.Random;
import java.awt.Graphics2D;
import java.util.ArrayList;
import java.util.concurrent.locks.Lock;

/**
 * This class contains 2 static methods for creating circle and square because
 * both shapes need to be created when the user clicks the button and when 2
 * different shapes collide
 *
 * @author Stefan
 */
public abstract class CreateShape {

    /**
     * Creates a circle
     *
     * @param circles array to add the newly created circle to
     * @param canvas canvas for the circle to be drawn on
     * @param canvasWidth width of the canvas
     * @param canvasHeight height of the canvas
     * @param bgColor background color of the factory
     * @param speed speed of the factory
     * @param lock lock
     */
    public static void createCircle(ArrayList circles, Graphics2D canvas, int canvasWidth, int canvasHeight, Color bgColor, double speed, Lock lock) {
        Random rand = new Random(); // To make a random number generator

        //1: Instantiate an instance of Circle class:
        Circle circle = new Circle(canvasWidth / 2, 2, 10, new Color(0, 0, 255), canvas);
        int[] boundary = {0, 0, canvasWidth, canvasHeight};
        circle.setBoundary(boundary);
        boolean facing = rand.nextInt(2) > 0.5; // to make the item have 1 in 2 change of moving left of right
        int speedX = 1 + rand.nextInt(8) + 2;
        int speedY = 12 - speedX;
        if (facing) {
            speedX *= -1;
        }
        circle.setSpeedX(speedX);
        circle.setSpeedY(speedY);
        circle.setBgColor(bgColor);
        circle.setSpeed(speed);
        circle.setLock(lock);

        //2: Declare a thread 
        Thread circleThread = new Thread(circle);

        //Add circle to circles array
        circles.add(circle);

        //3: Start the the circleThread;
        circleThread.start();
    }

    /**
     * Creates a square
     *
     * @param squares array to the the newly created square to
     * @param canvas canvas for the square to be drawn on
     * @param canvasWidth
     * @param canvasHeight height of the canvas
     * @param bgColor background color of the factory
     * @param speed speed of the factory
     * @param lock lock
     */
    public static void createSquare(ArrayList squares, Graphics2D canvas, int canvasWidth, int canvasHeight, Color bgColor, double speed, Lock lock) {
        Random rand = new Random(); // To make a random number generator

        Square square = new Square(canvasWidth / 2, 20, 20, new Color(255, 0, 0), canvas);
        int[] boundary = {0, 0, canvasWidth, canvasHeight};
        square.setBoundary(boundary);
        boolean facing = rand.nextInt(2) > 0.5; // to make the item have 1 in 2 change of moveing left of right
        int speedX = 1 + rand.nextInt(8) + 2;
        int speedY = 12 - speedX;
        if (facing) {
            speedX *= -1;
        }
        square.setSpeedX(speedX);
        square.setSpeedY(speedY);
        square.setBgColor(bgColor);
        square.setLock(lock);
        square.setSpeed(speed);

        //2: Declare a thread 
        Thread squareThread = new Thread(square);

        //Add square to circles array
        squares.add(square);
        //3: Start the the squareThread;
        squareThread.start();
    }

}
