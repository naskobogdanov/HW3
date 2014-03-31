using System;

class PrimeNumberCheck
{
    static void Main()
    {
        Console.WriteLine("Enter a number to check (between 0 and 100)");
        int number = int.Parse(Console.ReadLine());
                
        if (number < 0 || number > 100)
        {
            Console.WriteLine("Not a valid number");
        }
        else
        {
            bool Division = ( number % 2 > 0) && (number % 3 > 0) && (number % 5 > 0) && (number % 7 > 0);
            bool Equation = (number == 2) || (number == 3) || (number == 5) || (number == 7);
            bool isPrime = Division || Equation;


            if (isPrime == true)
            {
               Console.WriteLine("{0} is a prime number",number);
            }

            else
            {
               Console.WriteLine("{0} is a NOT prime number", number);
            }
        }
    }
}

