using System;

class OddOrEvenIntegers
{
    static void Main()
    {
        Console.WriteLine("Моля въведете цяло число");
        int number = int.Parse(Console.ReadLine());
        int nchecked = number % 2;
               
        if (nchecked != 0)
        {
            Console.WriteLine("Is Odd: True");
        }
        else
        {
            Console.WriteLine("Is Odd: False");
        }
        

    }
}

