using System;

public class Word
{
    private string _word;
    public void HideWord(string _word)
    {
        //split a word turn to a list of char
        char[] letters = _word.ToCharArray();

        //display "_" for the length of list letters 
        foreach(int i in letters)
        {
            Console.Write("{_}",i);
        }
    }
}