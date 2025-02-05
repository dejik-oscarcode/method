namespace Method_with_Palindrome;

public class Palindrome
{
    public string IsPalindrome(string word)
    {
        string convertedWord = word.ToLower();
        int length = convertedWord.Length;

        char[] reversed = new char[length];
        int j = 0;
        
        bool isPalindrome = true;
        
        for(int i = length - 1; i >= 0; i--)
        {
            reversed[j] = convertedWord[i];
            j++;
        }

        for(int i = 0; i < length; i++)
        {
            if (reversed[i] != convertedWord[i])
            {
                isPalindrome = false;
                break;
            }
        }
        
        return "IsPalindrome => " +  isPalindrome;
    }
}