using System;

class PointInsideACircleAndRactangle
{
    static void Main()
    {
        Console.WriteLine("This program will check if the coordinates are in circle K({1, 1}, 1,5) and out of rectangle ...");
        Console.WriteLine("Use \",\" for decimal separator");
        Console.WriteLine("Please enter x...");
        decimal xmin = -0.5m;
        decimal xmax = 2.5m;
        decimal xrmin = -1m;
        decimal xrmax = 5m;
        decimal x = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Please enter y...");
        decimal ymin = -0.5m;
        decimal ymax = 2.5m;
        decimal yrmin = -1m;
        decimal yrmax = 1m;
        decimal y = decimal.Parse(Console.ReadLine());
        
        decimal radius = 1.5m;
        if ((x > xmax || x < xmin || y > ymax || y < ymin) && (x < xrmax || x > xrmin || y < yrmax || y > yrmin))
        {
            Console.WriteLine("Not a valid coordinates");
        }
        else
        {
            if ((x * x) + (y * y) - (radius * radius) <= 0)
            {
                Console.WriteLine("The coordinates are in circle K({1, 1}, 1,5)");
                Console.WriteLine("x={0}", x);
                Console.WriteLine("y={0}", y);
            }
            else
            {
                Console.WriteLine("The coordinates are not in circle K({1, 1}, 1,5)");
                Console.WriteLine("x={0}", x);
                Console.WriteLine("y={0}", y);
            }

        }
    }
}
