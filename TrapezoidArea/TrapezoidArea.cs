using System;

class TrapezoidArea
{
    static void Main()
    {
        Console.WriteLine("Entter trapezoid side \"a\"");
        decimal a = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Entter trapezoid side \"b\"");
        decimal b = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Entter trapezoid hight \"h\"");
        decimal h = decimal.Parse(Console.ReadLine());

        decimal A = (a + b) * h / 2;

        if (a > 0 && b > 0 && h > 0)
        {
            Console.WriteLine("The trapezoid area is: {0}", A);
        }
        else
        {
            Console.WriteLine("One or many of the parameters are not valid");
        }

    }
}
