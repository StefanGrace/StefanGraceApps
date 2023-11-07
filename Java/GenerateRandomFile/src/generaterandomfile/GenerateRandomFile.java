/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package generaterandomfile;

import java.io.FileWriter;
import java.io.PrintWriter;
import java.io.IOException;
import java.util.Random;

/**
 *
 * @author Stefan
 */
public class GenerateRandomFile {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Random rand = new Random();
        String[] characters = {"0","1","2","3","4","5","6","7","8","9","!","@","#","$","%","^","&","*","(",")",
            "~","`","-","_","+","=","[","]",":",";","'","{","}","|","/","?","<",">",",",".",
            "a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z",
            "A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z"};
        FileWriter writer;
        try {
        writer = new FileWriter("random_data.txt", true);
        for (int i = 0; i < 10000000; i++) {
        writer.write(characters[rand.nextInt(characters.length)]);
        }
        writer.close();
        } catch (IOException e){
            
        }
        
        
    }
    
}
