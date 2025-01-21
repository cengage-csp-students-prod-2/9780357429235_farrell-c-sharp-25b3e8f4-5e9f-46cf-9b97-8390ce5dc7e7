In *Chapter 6*, you created a game named **GuessAWord** in which a player guesses letters to try to replicate a hidden word. Now write a modified version of the program named `GuessAWordWithExceptionHandling` that throws and catches an exception when the user enters a guess that is not a letter of the alphabet. Your error message should read:
```
Not a letter: #
# is not in the word
```
Create a `NonLetterException` class that descends from `Exception`. The `Message` string for your new class should indicate the nonletter character that caused the `Exception`'s creation. When a `NonLetterException` is thrown and caught, the message should be displayed.

## Grading 
This lab does not contain automated grading.
