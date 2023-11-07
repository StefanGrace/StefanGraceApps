import java.util.Scanner;

class NumberTranslator {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        boolean exit = false;
        while (!exit) {
            int inputNumber = 0;
            while (inputNumber == 0) {
                System.out.print("Provide a number: ");
                try {
                    inputNumber = Integer.parseInt(scanner.nextLine());
                    if (inputNumber < 1 || inputNumber > 30) {
                        System.out.println("The program only exepts number from 1 to 30");
                        inputNumber = 0;
                    }
                } catch (Exception e) {
                    System.out.println("You must enter an integer");
                    inputNumber = 0;
                } 
            }
            String outputLanguage = "";
            while (!outputLanguage.equals("french") && !outputLanguage.equals("german")) {
                System.out.print("What to translate to?: ");
                outputLanguage = scanner.nextLine().toLowerCase();
                if (!outputLanguage.equals("french") && !outputLanguage.equals("german")) {
                    System.out.println("The supported languages are French and German");
                }
            }
            String[] frenchNumbers = {"une/un", "deux", "trois", "quatre", "cinq", "six", "sept", "huit", "neuve/neuf", "dix", 
                "elfique", "douze", "treize", "quatorze", "quinze", "seize", "dix-sept", "dix-huit", "dix-neuf", "vingt", 
                "vingt et un", "vingt-deux", "vingt trois", "vingt quatre", "vingt cinq", "vingt-six", "vingt sept", "vingt-huit", "vingt-neuf", "trente"};
            String[] germanNumbers = {"einer", "zwei", "drei", "vier", "fünf", "sechs", "sieben", "acht", "neun", "zehn",
                "elf", "zwölf", "dreizehn", "vierzehn", "fünfzehn", "sechszehn", "siebzehn", "achtzehn", "neunzehn", "zwanzig", 
                "einundzwanzig", "zweiundzwanzig", "dreiundzwanzig", "vierundzwanzig", "fünfundzwanzig", "sechsundzwanzig", "siebenundzwanzig", "achtundzwanzig", "neunundzwanzig", "dreißig"};
            if (outputLanguage.equals("french")) {
                System.out.println(frenchNumbers[inputNumber - 1]);
            } else {
                System.out.println(germanNumbers[inputNumber - 1]);
            }
            System.out.print("Enter 1 to restart, anything else to exit: ");
            String exitChoice = scanner.nextLine();
            if (!exitChoice.equals("1")) {
                exit = true;
            }
        }
    }
}