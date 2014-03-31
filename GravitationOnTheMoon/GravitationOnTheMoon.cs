using System;

class GravitationOnTheMoon
{
    static void Main()
    {
        Console.WriteLine("Enter your weight (kg):");
        decimal weight = decimal.Parse(Console.ReadLine());
        decimal weightonmoon = weight * 17 / 100;
        Console.WriteLine("Your weight on the moon will be: {0}kg",weightonmoon);
        

    }
}

