<!-- manual -->
>This problem relies on the generation of a random number. You can create a random number that is at least min but less than max using the following statements:
```cs
Random ranNumberGenerator = new Random();
int randomNumber;
randomNumber = ranNumberGenerator.Next(min, max);
```

Create a lottery game application named *Lottery*. Generate three random numbers, each between 1 and 4. Allow the user to guess three numbers. 

Compare each of the user’s guesses to the three random numbers, and display a message that includes the user’s guess, the randomly determined three-digit number, and the amount of money the user has won as follows:


| **Matching Numbers** | **Award ($)** |
| -------- | -------- |
| Any one matching     | 10     |
| Two matching     | 100     |
| Three matching, not in order     | 1000    |
| Three matching in exact order     | 10,000    |
| No matches    | 0     |

Make certain that your application accommodates repeating digits. For example, if a user guesses 1, 2, and 3, and the randomly generated digits are 1, 1, and 1, do not give the user credit for three correct guesses—just one.

An example of the program is shown below: 
```
Enter a digit from 1 to 4 >> 2
Enter a second digit from 1 to 4 >> 3
And finally a third digit from 1 to 4 >> 4
The winning combination was 314
You won $100
```

### Grading
This lab does not contain automated grading. 