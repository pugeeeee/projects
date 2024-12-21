package Project;

import javax.swing.*;
import javax.swing.border.EmptyBorder;
import java.awt.*;
import java.io.File;
import java.util.Random;

public class Hangman {
    private JFrame frame;
    private JLabel wordLabel;
    private JLabel messageLabel;
    private JTextField inputField;
    private JButton guessButton;
    private JLabel attemptsLabel;

    private String[] words = {"programming", "java", "hangman", "developer", "computer", "algorithm", "debugging"};
    private String wordToGuess;
    private char[] guessedWord;
    private int attemptsRemaining = 6;

    public Hangman() {
        
        wordToGuess = getRandomWord(words);
        guessedWord = new char[wordToGuess.length()];
        for (int i = 0; i < guessedWord.length; i++) {
            guessedWord[i] = '_';
        }

     
        frame = new JFrame("Hangman Game");
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        frame.setSize(650, 500);

       //sir baka wala yung back ground pag ni run sa ibang device gawa po ng location kahit isinama sa same folder
        BackgroundPanel panel = new BackgroundPanel("C:\\Users\\Gerald\\Desktop\\java\\Games\\image\\kll.jpg");
        panel.setLayout(new GridLayout(5, 1));

        wordLabel = new JLabel(getGuessedWord(), SwingConstants.CENTER);
        wordLabel.setFont(new Font("Arial", Font.BOLD, 30));
        wordLabel.setForeground(Color.white);
        

        messageLabel = new JLabel("Guess a letter!", SwingConstants.CENTER);
        messageLabel.setFont(new Font("Arial", Font.PLAIN, 30));
        messageLabel.setForeground(Color.WHITE);
        

     
        inputField = new JTextField(1);
        inputField.setFont(new Font("Arial", Font.PLAIN, 20)); 
        inputField.setForeground(Color.black); 
        inputField.setBackground(new Color(240, 248, 255)); 
        inputField.setOpaque(true); 
        inputField.setBorder(BorderFactory.createLineBorder(Color.WHITE, 2));


        

        
        guessButton = new JButton("Enter Letter");
        guessButton.setFont(new Font("Arial", Font.BOLD, 20));
        guessButton.setForeground(Color.BLACK);
        guessButton.setContentAreaFilled(false);
        guessButton.setBorderPainted(true); 
        guessButton.setFocusPainted(true); 
        guessButton.setOpaque(false);
        guessButton.setBorder(new EmptyBorder(2, 5, 2, 5));

        attemptsLabel = new JLabel("Attempts remaining: " + attemptsRemaining, SwingConstants.CENTER);
        attemptsLabel.setFont(new Font("Arial", Font.PLAIN, 20));
        attemptsLabel.setForeground(Color.WHITE);

       
        panel.add(wordLabel);
        panel.add(messageLabel);
        panel.add(inputField);
        panel.add(guessButton);
        panel.add(attemptsLabel);

       
        frame.add(panel);
        frame.setVisible(true);

        guessButton.addActionListener(e -> processGuess());
    }

    private void processGuess() {
        String input = inputField.getText().toLowerCase();
        if (input.isEmpty() || input.length() > 1 || !Character.isLetter(input.charAt(0))) {
            messageLabel.setText("Enter a valid single letter!");
            return;
        }

        char guess = input.charAt(0);
        boolean correctGuess = false;

        for (int i = 0; i < wordToGuess.length(); i++) {
            if (wordToGuess.charAt(i) == guess && guessedWord[i] == '_') {
                guessedWord[i] = guess;
                correctGuess = true;
            }
        }

        if (!correctGuess) {
            attemptsRemaining--;
            messageLabel.setText("Incorrect guess!");
        } else {
            messageLabel.setText("Good guess!");
        }

        inputField.setText("");
        wordLabel.setText(getGuessedWord());
        attemptsLabel.setText("Attempts remaining: " + attemptsRemaining);

        if (attemptsRemaining == 0) {
            JOptionPane.showMessageDialog(frame, "Game Over! The word was: " + wordToGuess);
            resetGame();
        } else if (isWordGuessed()) {
            JOptionPane.showMessageDialog(frame, "Congratulations! You've guessed the word!");
            resetGame();
        }
    }

    private String getGuessedWord() {
        StringBuilder sb = new StringBuilder();
        for (char c : guessedWord) {
            sb.append(c).append(" ");
        }
        return sb.toString().trim();
    }

    private boolean isWordGuessed() {
        for (char c : guessedWord) {
            if (c == '_') {
                return false;
            }
        }
        return true;
    }

    private void resetGame() {
        wordToGuess = getRandomWord(words);
        guessedWord = new char[wordToGuess.length()];
        for (int i = 0; i < guessedWord.length; i++) {
            guessedWord[i] = '_';
        }
        attemptsRemaining = 6;
        wordLabel.setText(getGuessedWord());
        attemptsLabel.setText("Attempts remaining: " + attemptsRemaining);
        messageLabel.setText("Guess a letter!");
    }

    private String getRandomWord(String[] words) {
        Random random = new Random();
        return words[random.nextInt(words.length)];
    }

    public static void main(String[] args) {
        SwingUtilities.invokeLater(Hangman::new);
    }

    
    static class BackgroundPanel extends JPanel {
        private static final long serialVersionUID = 1L;
        private Image backgroundImage;

        public BackgroundPanel(String imagePath) {
            try {
                backgroundImage = new ImageIcon(imagePath).getImage();
            } catch (Exception e) {
                System.err.println("Image not found: " + imagePath);
            }
        }

        @Override
        protected void paintComponent(Graphics g) {
            super.paintComponent(g);
            if (backgroundImage != null) {
                g.drawImage(backgroundImage, 0, 0, getWidth(), getHeight(), this);
            }
        }
    }
}
