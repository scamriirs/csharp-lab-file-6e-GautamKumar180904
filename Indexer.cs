//Q-Write a program to show the concept of indexer

using System;
class Program
{
    private string[] studentName = new string[10];
    public string this[int index]
    {
        get
        {
            return studentName[index];
        }

        set
        {
            studentName[index] = value;
        }
    }
    public static void Main()
    {
        Program obj = new Program();
        obj[0] = "Shruti";
        obj[1] = "Ananya";
        obj[2] = "Srishty";

        Console.WriteLine("First element: " + obj[0]);
        Console.WriteLine("Second element: " + obj[1]);
        Console.WriteLine("Third element: " + obj[2]);
    }
}
