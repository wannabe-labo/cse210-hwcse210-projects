using System;
using System.Linq;

public class Scripture
{
    private string _text;

    //first, display scripture
    public void DisplayScripture()
    {
        Reference reference = new Reference();
        reference.Display();
        Console.WriteLine(_text);
    }
    //second,split text turn to a list of string, and randomly pick up the words until whole words hidden

    public void HideWords()
    {
        List<string> _words = new List<string>();
        _words = _text.Split(" ").ToList();
        int hw = 0;
        do{
            hw = _words.Count;
            // get 3 words from text
            foreach (int index in GetRandomIndex(0, _words.Count() - 1, 3))
            {
                string _word = _words[index];
                Word mw = new Word();
                mw.HideWord(_word);
            }

            hw = _words.Count - 3;
        } while (hw < 0);
    }

    // Create a unique index from a specified range
    public static IEnumerable<int> GetRandomIndex(int min, int max, int count)
    {
        var random = new Random();

        var indexList = new List<int>();
        for (int i = min; i <= max; i++) // include max
        {
            indexList.Add(i);
        }

        for (int i = 0; i < count; i++)
        {
            int index = random.Next(0, indexList.Count);
            int value = indexList[index];
            indexList.RemoveAt(index);
            yield return value;
        }
    }
}