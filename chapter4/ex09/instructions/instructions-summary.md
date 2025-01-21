<!--manual-->
>This problem relies on the generation of a random number. You can create a random number that is at least min but less than max using the following statements:
```cs
Random ranNumberGenerator = new Random();
int randomNumber;
randomNumber = ranNumberGenerator.Next(min, max);
```

In the game Rock Paper Scissors, two players simultaneously choose one of three
options: rock, paper, or scissors. If both players choose the same option, then the
result is a tie. However, if they choose differently, the winner is determined as follows:
* Rock beats scissors, because a rock can break a pair of scissors.
* Scissors beats paper, because scissors can cut paper.
* Paper beats rock, because a piece of paper can cover a rock.

Create a game in which the computer randomly chooses rock, paper, or scissors. 

Let the user enter a character, r, p, or s, each representing one of the three choices. Then, determine the winner. 

Save the application as *RockPaperScissors.cs*.

### Grading
This lab does not contain automated grading.
