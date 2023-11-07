/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Models;

/**
 * Contains move and draw methods for shapes
 *
 * @author Stefan
 */
public interface IMoveAndDraw {

    public void move(int speedX, int speedY, int angle);

    public void draw();
}
