// Write a Program  to show usage of this Keyword.
using System;
class Test
{
    int num;
    public Test(int num)
    {
        this.num=num;
    }
    public void Display()
    {
        Console.WriteLine("Value is " + num);
    }
    public static void Main()
    {
        Test t = new Test(5);
        t.Display();
    }
}
