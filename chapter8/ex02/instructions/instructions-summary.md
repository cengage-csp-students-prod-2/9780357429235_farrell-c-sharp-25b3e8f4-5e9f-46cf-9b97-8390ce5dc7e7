Create a program named _IntegerFacts_ whose `Main()` method declares an array of ten integers.

Call a method named `FillArray` to interactively fill the array with any number of values up to ten or until a sentinel value (**999**) is entered. If an entry is not an integer, re-prompt the user. Return the number of values actually in the array

Call a second method named `Statistics` that accepts out parameters for the highest value in the array, lowest value in the array, sum of the values in the array, and arithmetic average. The method signature should be `Statistics(int[] array, int value, out int max, out int min, out int sum, out double avg)`

In the `Main()` method, display all the statistics in the following format:

```
The array has 2 values
The highest value is 11
The lowest value is 1
The sum of the values is 12
The average is 6
```

> The inputs were **1**, **11**, and **999**
