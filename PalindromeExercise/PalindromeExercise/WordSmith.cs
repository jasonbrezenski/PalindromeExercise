using System;

namespace PalindromeExercise;

public class WordSmith
{
    public bool IsAPalindrome(string word)
    {
        var reversedWord = "";

        for (int i = word.Length - 1; i >= 0; i--)
        {
            reversedWord += word[i];
        }

        if (reversedWord.ToLower() == word.ToLower())
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}