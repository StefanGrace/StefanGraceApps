/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Models;

import java.awt.Color;
import java.util.ArrayList;
import java.util.Random;
import java.awt.Graphics2D;
import java.util.concurrent.locks.Lock;

/**
 * Detects and handles collisions between shapes and shapes, and shapes and
 * factory components
 *
 * @author Stefan
 */
public class CollisionHandler extends SpeedControl implements Runnable {

    // Properties
    private ArrayList<Shape> circles = new ArrayList<>();
    private ArrayList<Shape> squares = new ArrayList<>();
    private final Wall[] wallAndGate;
    private final Windmill wm;
    private volatile boolean exit = false;
    private int circleSqaureCollisionTimer = 0; // to stop muliple collsions being detected when there should only be 1
    private final Graphics2D canvas;
    private final Lock lock;
    private final int[] boundary;
    private Color bgColor;

    // Constructor
    /**
     *
     * @param circles array of circle to check collisions on
     * @param squares array of squares to check collisions on
     * @param wallAndGate walls and gates to check collisions with circles and
     * squares
     * @param wm windmill to check collisions with circles and squares
     * @param canvas canvas to pass down to newly created shapes
     * @param boundary the edges of the canvas
     * @param lock lock
     * @param bgColor background color of the canvas;
     */
    public CollisionHandler(ArrayList<Shape> circles, ArrayList<Shape> squares, Wall[] wallAndGate, Windmill wm, Graphics2D canvas, int[] boundary, Lock lock, Color bgColor) {
        this.circles = circles;
        this.squares = squares;
        this.wallAndGate = wallAndGate;
        this.wm = wm;
        this.canvas = canvas;
        this.boundary = boundary;
        this.lock = lock;
        this.bgColor = bgColor;
    }

    // Methods
    @Override
    public void run() {
        while (!exit) {
            if (circleSqaureCollisionTimer > 0) {
                circleSqaureCollisionTimer--;
            }
            try {
                int[] circlesToRemove = {-1, -1};
                if (circles != null) {
                    for (int i = 0; i < circles.size(); i++) {
                        // Check if a circle is colliding with another circle
                        for (int j = 0; j < circles.size(); j++) {
                            if (checkCollision(circles.get(i), circles.get(j)) && i != j) {
                                circlesToRemove[0] = i;
                                circlesToRemove[1] = j;
                            }
                        }
                        // Check if a circle is colliding with a square
                        if (squares != null) {
                            for (int j = 0; j < squares.size(); j++) {
                                if (checkCollision(circles.get(i), squares.get(j))) {
                                    if (circleSqaureCollisionTimer == 0) {
                                        Random random = new Random();
                                        if (random.nextInt(2) == 1) {
                                            CreateShape.createCircle(circles, canvas, boundary[2], boundary[3], bgColor, speed, lock);
                                        } else {
                                            CreateShape.createSquare(squares, canvas, boundary[2], boundary[3], bgColor, speed, lock);
                                        }
                                        circleSqaureCollisionTimer = 10;
                                    }
                                }
                            }
                        }
                        // Check if a circle is colliding with a wall or gate
                        if (wallAndGate != null) {
                            for (Wall wallGate : wallAndGate) {
                                String collisionOutcome = checkCollision(circles.get(i), wallGate);
                                switch (collisionOutcome) {
                                    case "left":
                                        circles.get(i).setSpeedX(circles.get(i).getSpeedX() * -1);
                                        break;
                                    case "right":
                                        circles.get(i).setSpeedX(circles.get(i).getSpeedX() * -1);
                                        break;
                                    case "top":
                                        circles.get(i).setSpeedY(circles.get(i).getSpeedY() * -1);
                                        break;
                                    case "bottom":
                                        circles.get(i).setSpeedY(circles.get(i).getSpeedY() * -1);
                                        break;
                                    case "none":
                                        break;
                                }
                            }
                        }
                        // Check if a circle is colliding with a windmill
                        if (wm != null) {
                            handelCollision(circles.get(i), wm);
                        }
                    }
                }
                int[] squaresToRemove = {-1, -1};
                if (squares != null) 
                {
                    for (int i = 0; i < squares.size(); i++) {
                        // Check if a square is colliding with another square
                        for (int j = 0; j < squares.size(); j++) {
                            if (checkCollision(squares.get(i), squares.get(j)) && i != j) {
                                squaresToRemove[0] = i;
                                squaresToRemove[1] = j;
                            }
                        }
                        // Check if a square is colliding with a wall or gate
                        if (wallAndGate != null) {
                            for (Wall wallGate : wallAndGate) {
                                String collisionOutcome = checkCollision(squares.get(i), wallGate);
                                switch (collisionOutcome) {
                                    case "left":
                                        squares.get(i).setSpeedX(squares.get(i).getSpeedX() * -1);
                                        break;
                                    case "right":
                                        squares.get(i).setSpeedX(squares.get(i).getSpeedX() * -1);
                                        break;
                                    case "top":
                                        squares.get(i).setSpeedY(squares.get(i).getSpeedY() * -1);
                                        break;
                                    case "bottom":
                                        squares.get(i).setSpeedY(squares.get(i).getSpeedY() * -1);
                                        break;
                                    case "none":
                                        break;
                                }
                            }
                        }
                        // Check if a square is colliding with a windmill
                        if (wm != null) {
                            handelCollision(squares.get(i), wm);
                        }
                    }
                }
                // Remove circles that shoud be removed
                for (int i = 0; i < circlesToRemove.length; i++) {
                    if (circlesToRemove[i] != -1) {
                        circles.get(circlesToRemove[i]).stop();
                        circles.remove(circlesToRemove[i]);
                    }
                }
                // Remove squares that shoud be removed
                for (int i = 0; i < squaresToRemove.length; i++) {
                    if (squaresToRemove[i] != -1) {
                        squares.get(squaresToRemove[i]).stop();
                        squares.remove(squaresToRemove[i]);
                    }
                }
                try {
                    //Delay 100ms times the speed of the factory
                    Thread.sleep(Math.round((100.0 * (1.0 / speed))));
                } catch (InterruptedException e) {
                }
            } catch (Exception e) {
                System.out.println(e);
            } finally {

            }
        }
    }

    /**
     * Change the direction of travel when shapes hit the windmill
     *
     * @param shape shape to check if hitting windmill
     * @param wm windmill to check if the shape is hitting
     */
    private void handelCollision(Shape shape, Windmill wm) {
        String collisionOutcome = checkCollision(shape, wm);
        switch (collisionOutcome) {
            case "top":
                shape.setSpeedX(6);
                shape.setSpeedY(-6);
                break;
            case "right":
                shape.setSpeedX(6);
                shape.setSpeedY(6);
                break;
            case "bottom":
                shape.setSpeedX(-6);
                shape.setSpeedY(6);
                break;
            case "left":
                shape.setSpeedX(-6);
                shape.setSpeedY(-6);
                break;
            case "top left":
                shape.setSpeedX(0);
                shape.setSpeedY(-10);
                break;
            case "top right":
                shape.setSpeedX(10);
                shape.setSpeedY(0);
                break;
            case "bottom left":
                shape.setSpeedX(-10);
                shape.setSpeedY(0);
                break;
            case "bottom right":
                shape.setSpeedX(0);
                shape.setSpeedY(10);
                break;
            case "none":
                break;
        }
    }

    /**
     * Checks if there is a collision between 2 shapes
     *
     * @param item1 first shape
     * @param item2 second shape
     * @return true if there is a collision and false if there is not
     */
    private boolean checkCollision(Shape item1, Shape item2) {
        // Calculate the center coordinates of 2 objects
        int item1CenterX = item1.getTopLeftX() + item1.getWidth() / 2;
        int item1CenterY = item1.getTopLeftY() + item1.getHeight() / 2;
        int item2CenterX = item2.getTopLeftX() + item2.getWidth() / 2;
        int item2CenterY = item2.getTopLeftY() + item2.getHeight() / 2;

        // Calculate the distance between the center of the 2 objects
        int centralDistanceX = Math.abs(item1CenterX - item2CenterX);
        int centralDistanceY = Math.abs(item1CenterY - item2CenterY);

        //3: Check if there is a collison
        return centralDistanceX <= (item1.getWidth() / 2 + item2.getWidth() / 2)
                && centralDistanceY <= (item1.getHeight() / 2 + item2.getHeight() / 2);
    }

    /**
     * Check if there is collision between a shape and a gate or wall and where
     * it hits
     *
     * @param shape shape to check collision with wall or gate
     * @param wallOrGate wall or gate
     * @return "left", "right", "top" or "bottom" depending on which side the
     * shape collided with or "none" if there is no collision
     */
    private String checkCollision(Shape shape, Wall wallOrGate) {
        //1: Calculate the center coordinate the object
        int shapeCenterX = shape.getTopLeftX() + shape.getWidth() / 2;
        int shapeCenterY = shape.getTopLeftY() + shape.getHeight() / 2;

        //2: Check which side of the wall or gate the shape is touching (if any)
        if (shapeCenterX >= wallOrGate.getTopLeftX() && shapeCenterX < wallOrGate.getTopLeftX() + 15
                && shapeCenterY < (wallOrGate.getTopLeftY() + wallOrGate.getHeight()) - 15 && shapeCenterY > wallOrGate.getTopLeftY() + 15) {
            return "left";
        } else if (shapeCenterX >= (wallOrGate.getTopLeftX() + wallOrGate.getWidth() - 15) && shapeCenterX < wallOrGate.getTopLeftX() + wallOrGate.getWidth()
                && shapeCenterY < (wallOrGate.getTopLeftY() + wallOrGate.getHeight()) - 15 && shapeCenterY > wallOrGate.getTopLeftY() + 15) {
            return "right";
        } else if (shapeCenterY >= wallOrGate.getTopLeftY() && shapeCenterX < wallOrGate.getTopLeftY() + 15
                && shapeCenterX < (wallOrGate.getTopLeftX() + wallOrGate.getWidth()) - 15 && shapeCenterX > wallOrGate.getTopLeftX() + 15) {
            return "top";
        } else if (shapeCenterY >= (wallOrGate.getTopLeftY() + wallOrGate.getHeight() - 15) && shapeCenterY < wallOrGate.getTopLeftY() + wallOrGate.getHeight()
                && shapeCenterX < (wallOrGate.getTopLeftX() + wallOrGate.getWidth()) - 15 && shapeCenterX > wallOrGate.getTopLeftX() + 15) {
            return "bottom";
        } else {
            return "none";
        }
    }

    /**
     * Check if a shape has collided with the windmill and which side it
     * collided with
     *
     * @param shape shape to check collision with windmill
     * @param wm windmill
     * @return "top", "bottom", "left", "right", "top left", "top right",
     * "bottom right", "bottom left" and "none"
     */
    private String checkCollision(Shape shape, Windmill wm) {
        //1: Calculate the center coordinate the shape
        int shapeCenterX = shape.getTopLeftX() + shape.getWidth() / 2;
        int shapeCenterY = shape.getTopLeftY() + shape.getHeight() / 2;
        //2: check if the shape is the the area of the windmill
        if (shapeCenterX >= wm.getCenterX() - (wm.getWidth() / 2) && shapeCenterX < wm.getCenterX() + (wm.getWidth() / 2)
                && shapeCenterY >= wm.getCenterY() - (wm.getHeight() / 2) && shapeCenterY < wm.getCenterY() + (wm.getHeight() / 2)) {
            //3: If the shape is in the area of the windmill, check what position the windmill is in
            //4: Check which part of the windmill the shape is touching
            if (wm.isRotated()) {
                // like a 'X' shape
                int shapeFromWmCenterX = Math.abs(shapeCenterX - wm.getCenterX());
                int shapeFromWmCenterY = Math.abs(shapeCenterY - wm.getCenterY());
                String quater = checkQuarter(shapeCenterX, shapeCenterY, wm);
                switch (quater) {
                    case "top left":
                        if (shapeFromWmCenterX > shapeFromWmCenterY) {
                            return "left";
                        } else {
                            return "top";
                        }
                    case "top right":
                        if (shapeFromWmCenterX > shapeFromWmCenterY) {
                            return "right";
                        } else {
                            return "top";
                        }
                    case "bottom left":
                        if (shapeFromWmCenterX > shapeFromWmCenterY) {
                            return "left";
                        } else {
                            return "bottom";
                        }
                    case "bottom right":
                        if (shapeFromWmCenterX > shapeFromWmCenterY) {
                            return "right";
                        } else {
                            return "bottom";
                        }
                }
            } else {
                // like a '+' shape
                return checkQuarter(shapeCenterX, shapeCenterY, wm);
            }
        }
        return "none";
    }

    /**
     * *
     * Checks what quarter of the windmill the shape is in when the windmill
     * looks like a '+'
     *
     * @param shapeCenterX the x coordinate of the center of the shape
     * @param shapeCenterY the y coordinate of the center of the shape
     * @param wm windmill
     * @return "top right", "top left", "bottom right" or "bottom left"
     */
    private String checkQuarter(int shapeCenterX, int shapeCenterY, Windmill wm) {
        if (shapeCenterX > wm.getCenterX()) {
            // right
            if (shapeCenterY > wm.getCenterY()) {
                // top right
                return "top right";
            } else {
                // bottom right
                return "bottom right";
            }
        } else {
            // left
            if (shapeCenterY > wm.getCenterY()) {
                // top left
                return "top left";
            } else {
                // bottom left
                return "bottom left";
            }
        }
    }

    public void setBgColor(Color bgColor) {
        this.bgColor = bgColor;
    }
}
