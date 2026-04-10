// See https://aka.ms/new-console-template for more information

using System;
using Method_with_Palindrome;

Palindrome palindrome = new Palindrome();

Console.WriteLine(palindrome.IsPalindrome("Abbey"));

Fibonacci fibonacci = new Fibonacci();

Console.WriteLine(fibonacci.PrintFibonacci(10));

OptionsMethod optionsMethod = new OptionsMethod();

Console.WriteLine("Welcome To A4 Computation....");
Console.Write("Select option to perform:\n1. To reverse digits\n2. To print the average of sequence of numbers in array\n3. To perform linear equation.\n");
int option = Convert.ToInt32(Console.ReadLine());

optionsMethod.ChooseOption(option);




