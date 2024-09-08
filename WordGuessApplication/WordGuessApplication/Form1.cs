using System;
using System.Text;
using System.Windows.Forms;

namespace WordGuessApplication
{
    public partial class Form1 : Form
    {
        private readonly string wordToGuess = "computer";
        private readonly StringBuilder wrongGuesses = new StringBuilder();

        public Form1()
        {
            InitializeComponent();

            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            labelResult.Text = CluedWord(wordToGuess);
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            
            string guessedWord = textBoxGuess.Text.Trim();

            if (string.Equals(guessedWord, wordToGuess, StringComparison.OrdinalIgnoreCase))
            {
                
                labelResult.Text = wordToGuess;

                MessageBox.Show("Congratulations! You guessed the word correctly!", "Correct Guess", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                wrongGuesses.AppendLine(guessedWord);
                listBoxWrongGuesses.Items.Add(guessedWord);

                labelResult.Text = CluedWord(wordToGuess);

                MessageBox.Show("Wrong guess. Try again!", "Incorrect Guess", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            textBoxGuess.Clear();
        }

        private string CluedWord(string word)
        {
            if (word.Length <= 2)
            {
                return word; 
            }

            StringBuilder maskedWord = new StringBuilder();
            maskedWord.Append(word[0]); 
            maskedWord.Append(new string('?', word.Length - 2)); 
            maskedWord.Append(word[word.Length - 1]); 

            return maskedWord.ToString();
        }
    }
}