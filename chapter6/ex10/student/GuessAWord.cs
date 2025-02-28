using System;
using static System.Console;
using System.Globalization;
class GuessAWord
{
    static void Main()
    {
        string[] words = { "mexican", "indian", "italian", "chinese", "japanese", "french", "thai", "greek", "american" };

        Random ranNumberGenerator = new Random();
        int randomNumber;
        randomNumber = ranNumberGenerator.Next(0, words.Length);
        string hiddenWord = words[randomNumber];

        char[] guessedWord = new string('*', hiddenWord.Length).ToCharArray();

        bool wordFilled = false;

        WriteLine("This is guess a word!");
        WriteLine("To play, you must guess the hidden word, only use one letter per guess.");

        while (!wordFilled)
        {
            WriteLine("\nWord: " + new string(guessedWord));
            Write("Guess a letter: ");
            char guess = ReadLine().ToLower()[0];

            bool rightGuess = false;

            for (int x = 0; x < hiddenWord.Length; x++)
            {
                if (hiddenWord[x] == guess)
                {
                    guessedWord[x] = guess;
                    rightGuess = true;
                }
            }
            if (rightGuess)
            {
                WriteLine("Yes, '{0}' is in the word", guess);
            }
            else
            {
                WriteLine("Sorry, '{0}' is not in the word", guess);
            }
            if (new string(guessedWord) == hiddenWord)
            {
                wordFilled = true;
                WriteLine("Awesome! You have correctly guess that {0} is the hidden word!", hiddenWord);
            }
        }
    }
}