using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage: ");
        int percentage = int.Parse(Console.ReadLine());
     
        string note;

        if (percentage >= 90)
        {
            note = "A";
        }
        else if (percentage >= 80)
        {
            note = "B";
        }
        else if (percentage >= 70)
        {
            note = "C";
        }
        else if (percentage >= 60)
        {
            note = "D";
        }
        else
        {
            note = "F";
        }

        Console.WriteLine($"Your rating in letters is: {note}");

        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed.");
        }
        else
        {
            Console.WriteLine("Don't give up! You can do better next time.");
        }
    }

}