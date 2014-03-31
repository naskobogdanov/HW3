using System;

class PointInACircle
{
    static void Main()
    {
        Console.WriteLine("This program will check if the coordinates are in circle K({0, 0}, 2)");
        Console.WriteLine("Use \",\" for decimal separator");
        Console.WriteLine("Please enter x...");
        decimal xmin = -2;
        decimal xmax = 2;
        decimal x = decimal.Parse(Console.ReadLine());
        
        Console.WriteLine("Please enter y...");
        decimal ymin = -2;
        decimal ymax = 2;
        decimal y = decimal.Parse(Console.ReadLine());

        if (x > xmax || x < xmin || y > ymax || y < ymin)
        {
            Console.WriteLine("Not a valid coordinates");
        }
        else
        {
            Console.WriteLine("The coordinates are in circle K({0, 0}, 2)");
            Console.WriteLine("x={0}",x);
            Console.WriteLine("y={0}",y);
        }
    }
}

