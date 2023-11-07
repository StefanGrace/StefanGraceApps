import java.io.FileWriter;
import java.io.PrintWriter;
import java.io.IOException;
import java.util.Random;
import java.io.File; 
import java.io.FileNotFoundException;  
import java.util.Scanner;

class GenerateRandomLetterCodes {
    
    public static void main(String[] args) {
        String[] usedLetterCodes = readLetterCodesFromFile();
        String letterCode = generateUniqueLetterCode(usedLetterCodes);
        writeLetterCodeToFile(letterCode); 
    }
    
    public static String[] readLetterCodesFromFile() {
        try {
            File usedLetterCodesFile = new File("UsedLetterCodes.txt");
            Scanner reader = new Scanner(usedLetterCodesFile);
            String[] usedLetterCodes = new String[676];
            for (int i = 0; reader.hasNextLine(); i++) {
                usedLetterCodes[i] = reader.nextLine();
            }
            reader.close();
            return usedLetterCodes;
        } catch (Exception e) {
            System.out.println("Error reading file");
            return new String[676];
        }   
    }
    
    public static String generateUniqueLetterCode(String[] usedLetterCodes) {
        boolean duplicate = true;
        String letterCode = "";
        while (duplicate) {
            letterCode = generateNewLetterCode();
            duplicate = false;
            for (String usedLetterCode : usedLetterCodes) {
                if (usedLetterCode != null) {
                    if (usedLetterCode.equals(letterCode)) {
                        duplicate = true;
                        System.out.println("Duplicate letter code");
                    }
                }
            }
        }
        return letterCode;
    }
    
    public static String generateNewLetterCode() {
        Random rand = new Random();
        String[] characters = {"A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z"};
        String letterCode = "";
        for (int i = 0; i < 2; i++) {
            letterCode += characters[rand.nextInt(characters.length)]; 
        }
        System.out.println(letterCode);
        return letterCode;
    }
    
    public static void writeLetterCodeToFile(String letterCode) {
        FileWriter writer;
        try {
            writer = new FileWriter("UsedLetterCodes.txt", true);
            writer.write(letterCode + "\r\n");
            writer.close();
            System.out.println("Letter code added to file");
        } catch (Exception e) {
            System.out.println("Error adding letter code to file");
        }
    }
    
}