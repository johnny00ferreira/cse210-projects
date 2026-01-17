using System;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _responseText;

    public void Display()
    {
        Console.WriteLine($"{_date} - {_promptText}");
        Console.WriteLine(_responseText);
        Console.WriteLine();
    }
}
