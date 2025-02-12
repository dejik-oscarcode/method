namespace Method_with_Palindrome;

public class Fibonacci
{
    public long PrintFibonacci(int n)
    {
        if (n <= 2)
        {
            return 1;
        }
        else
        {
            return PrintFibonacci(n - 1) + PrintFibonacci(n - 2);
        }
    }
}