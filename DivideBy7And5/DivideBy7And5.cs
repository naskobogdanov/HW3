using System;

class DivideBy7And5
{
    static void Main()
    {
        Console.WriteLine("Type a intager number:");
        int number = int.Parse(Console.ReadLine());
        int num5 = number % 5;
        int num7 = number % 7;
        if (num5 == 0 && num7 == 0) 
        {
            Console.WriteLine("The number CAN be devidet on 5 and 7 at the same time");
        }
        else 
        {
            Console.WriteLine("The number can NOT be devided on 5 and 7 at the same time");
        }
    }
}

