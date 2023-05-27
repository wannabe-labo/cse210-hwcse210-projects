using System;

public class Reference
{
    private string _book;
    private int _chapter;
    private string _verse;

    public void Display()
    {
        Console.WriteLine($"{_book} {_chapter}:{_verse}");
    }
}