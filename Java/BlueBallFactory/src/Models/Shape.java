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
 * Abstract class the circle and square inherit from
 * @author stefan
 */
abstract public class Shape extends SpeedControl{

    //Properties
    protected int topLeftX;
    protected int topLeftY;
    protected int width;
    protected int height;
    protected Color color;
    protected Color bgColor;
    protected Graphics2D canvas;
    protected int speedX = 10;
    protected int speedY = 5;
    protected int angle = 0;
    protected int[] boundary = new int[4];//[0]:topX,[1]:topY,[2]:bottomX,[3]:bottomY
    // Lock
    protected Lock lock;

    //Constructor
    /**
     *
     * @param topLeftX the top left x coordinate
     * @param topLeftY the top left y coordinate
     * @param width the width of the shape
     * @param height the height of the shape
     * @param color the color of the shape
     * @param canvas the canvas that the shape will be drawn on
     */
    public Shape(int topLeftX, int topLeftY, int width, int height, Color color, Graphics2D canvas) {
        this.topLeftX = topLeftX;
        this.topLeftY = topLeftY;
        this.width = width;
        this.height = height;
        this.color = color;
        this.canvas = canvas;
    }

    //Methods
    @Override
    public String toString() {
        return "Cordinates: (" + topLeftX + "," + topLeftY + ")" + ". W x H: " + width + "x" + height;
    }

    public void stop() {

    }

    // Seters and Getters
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

    public Color getColor() {
        return color;
    }

    public Color getBgColor() {
        return bgColor;
    }

    public void setBgColor(Color bgColor) {
        this.bgColor = bgColor;
    }

    public int getSpeedX() {
        return speedX;
    }

    public void setSpeedX(int speedX) {
        this.speedX = speedX;
    }

    public int getSpeedY() {
        return speedY;
    }

    public void setSpeedY(int speedY) {
        this.speedY = speedY;
    }

    public int getAngle() {
        return angle;
    }

    public void setAngle(int angle) {
        this.angle = angle;
    }

    public int[] getBoundary() {
        return boundary;
    }

    public void setBoundary(int[] boundary) {
        this.boundary = boundary;
    }

    public void setColor(Color color) {
        this.color = color;
    }

    public Graphics2D getCanvas() {
        return canvas;
    }

    public void setCanvas(Graphics2D canvas) {
        this.canvas = canvas;
    }

    public Lock getLock() {
        return lock;
    }

    public void setLock(Lock lock) {
        this.lock = lock;
    }

}
