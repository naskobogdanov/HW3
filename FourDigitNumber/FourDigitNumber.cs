using System;

class FourDigitNumber
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter your 4 digit number below...");

        int startnumber = 1000;
        int endnumber = 9999;
        int number = int.Parse(Console.ReadLine());
        int a = (number / 1000) % 10;
        int b = (number / 100) % 10;
        int c = (number / 10) % 10;
        int d = (number) % 10;
        int sum = a + b + c + d;

        if (number > endnumber || number < startnumber)
        {
            Console.WriteLine("Not a valid number");
        }
        else
        {
            Console.WriteLine("Your number is: {0}", number);
            Console.WriteLine("The sum of digits is: {0}", sum);
            Console.WriteLine("The reverse number is: {3}{2}{1}{0}", a, b, c, d);
            Console.WriteLine("The last digit infront number is: {3}{0}{1}{2}", a, b, c, d);
            Console.WriteLine("The second and third digit exchanged number is: {0}{2}{1}{3}", a, b, c, d);
        }   
    }
}

