>This problem relies on the generation of a random number. You can create a random number that is at least min but less than max using the following statements:
```cs
Random ranNumberGenerator = new Random();
int randomNumber;
randomNumber = ranNumberGenerator.Next(min, max);
```

Write a program named *GuessingGame* that generates a random number between 1 and 10. (In other words, in the example above, min is 1 and max is 11.)

Ask a user to guess the random number, then display the random number and a message indicating whether the user’s guess was too high, too low, or correct.

### Grading
This lab does not contain automated grading.