using System;

class ThirdDigitIs7
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter an intager number to check:");
        int number = int.Parse(Console.ReadLine());
        int num7 = (number/100) % 10;
        if (num7 == 7)
        {
            Console.WriteLine("the third number is 7");
        }
        else
            Console.WriteLine("the third number is NOT 7");



    }
}

