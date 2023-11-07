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
 * The class that the windmill, wall and gate inherit from
 *
 * @author Stefan
 */
public abstract class FactoryComponent extends SpeedControl {

    // Properties
    protected Color color;
    protected Color bgColor;
    protected Graphics2D canvas;
    // Lock
    protected Lock lock;

    // Constructor
    /**
     *
     * @param color color of the object drawn on the canvas
     * @param bgColor background color of the canvas
     * @param canvas canvas to draw the object on
     */
    public FactoryComponent(Color color, Color bgColor, Graphics2D canvas) {
        this.color = color;
        this.bgColor = bgColor;
        this.canvas = canvas;
    }

    // Methods
    public void draw() {

    }

    // Setters and Getters
    public Lock getLock() {
        return lock;
    }

    public void setLock(Lock lock) {
        this.lock = lock;
    }

    public Color getColor() {
        return color;
    }

    public void setColor(Color color) {
        this.color = color;
    }

    public Color getBgColor() {
        return bgColor;
    }

    public void setBgColor(Color bgColor) {
        this.bgColor = bgColor;
    }

    public Graphics2D getCanvas() {
        return canvas;
    }

    public void setCanvas(Graphics2D canvas) {
        this.canvas = canvas;
    }

}
