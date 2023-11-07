/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Models;

/**
 * Abstract class for everything that moves to inherit, so that the speed of the
 * factory can be adjusted
 *
 * @author Stefan
 */
public abstract class SpeedControl {

    /**
     * Factory speed multiplier
     */
    protected double speed = 1.0;

    public void setSpeed(double speed) {
        this.speed = speed;
    }
}
