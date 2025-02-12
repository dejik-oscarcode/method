using System;
using System.Collections.Generic;

namespace Method_with_Palindrome;

public class OptionsMethod
{
    public int ChooseOption(int option)
    {
        RunOperation(option);
        return option;
    }

    private int RunOperation(int option)
    {
        switch(option)
        {
            case 1:
                Console.Write("Please, enter digits to reverse: ");
                int digits = Convert.ToInt32(Console.ReadLine());
                
                ReversedOrder(digits);
                break;
            case 2:
                // Console.Write("Please, enter the length of the array: ");
                //  int length = Convert.ToInt32(Console.ReadLine());
                //
                //  int [] array = new int [length];
                //  for(int i = 0; i < length; i++)
                //  {
                //      Console.Write($"array[{i}] =  ");
                //      array[i] = Convert.ToInt32(Console.ReadLine());
                //  }
                
                int[] array = { 1, 2, 3, 4, 5 };
                Console.WriteLine(PrintAverageSequenceOfNumbers(array));
                break;
            case 3:
                Console.Write("Enter the value of a: ");
                int a = Convert.ToInt32(Console.ReadLine());
                
                Console.Write("Enter the value of b: ");
                int b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(PrintLinearEquation(a, b));
                break;
                
        }

        return option;
    }

    private void ReversedOrder(int digits)
    {
        string temp = digits.ToString();

        for (int i = temp.Length - 1; i >= 0; i--)
        {
            Console.Write(temp[i]);
        }
    }

    private int PrintAverageSequenceOfNumbers(int [] numbers)
    {
        int sum = 0;
        int averageOfSequenceOfNumbers = 0;

        for(int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
            averageOfSequenceOfNumbers  = sum / numbers.Length;
        }

        return averageOfSequenceOfNumbers;
    }

    private double PrintLinearEquation(int a, int b)
    {
        // a * x + b = 0
        int x = b / a;
        
        return x;
    } 
}