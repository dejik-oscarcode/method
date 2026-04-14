namespace Method_with_Palindrome;

public class NumberAppearance
{
    public int PrintNumberAppearances(int [] arrayNumbers, int number)
    {
        int counter = 0;

        for(int i = 0; i < arrayNumbers.Length; i++)
        {
            if (number == arrayNumbers[i])
            {
                counter++;
                
            }
        }
        return counter;
    }
}
