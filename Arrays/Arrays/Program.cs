using System;
using System.Linq;
/*

Exercise 1: Calculate the Average of a Double Array
Write a method that calculates and returns the average value of an array of doubles.

Exercise 2: Find the Minimum Value in a Two-Dimensional Array
Create a method to find and return the minimum value in a two-dimensional array of integers.

Exercise 3: Sum Each Row in a Two-Dimensional Array
Write a method that takes a two-dimensional array of integers,
sums the elements of each row,
and returns an array containing the sum of each row.

Exercise 4: Transpose a Matrix
Implement a method that transposes a matrix
(swaps rows and columns) and returns the transposed two-dimensional array.

Exercise 5: Diagonal Sum of a Square Matrix
Write a method that calculates the sum of the diagonal elements
of a square two-dimensional array.


Ex1
public static double CalculateAverage(double[] numbers)
{
    double sum = 0;
    foreach (double number in numbers)
    {
        sum += number;
    }
    return sum / numbers.Length;
}

Ex2
public static int FindMinimum(int[,] matrix)
{
    int min = matrix[0, 0];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min)
            {
                min = matrix[i, j];
            }
        }
    }
    return min;
}

Ex3
public static int[] SumRows(int[,] matrix)
{
    int[] rowSums = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        rowSums[i] = sum;
    }
    return rowSums;
}



Ex5
public static int DiagonalSum(int[,] matrix)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sum += matrix[i, i];
    }
    return sum;
}

*/