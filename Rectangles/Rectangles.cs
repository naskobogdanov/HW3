using System;

class Rectangles
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter ractangle height:");
        int height = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter ractangle width:");
        int width = int.Parse(Console.ReadLine());

        int perimater = 2 * height + 2 * width;
        int area = height * width;

        Console.WriteLine("The ractangle is with perimeter {0} and area {1}" ,perimater,area);
    }
}

