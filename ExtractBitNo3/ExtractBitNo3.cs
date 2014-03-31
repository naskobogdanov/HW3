using System;

class ExtractBitNo3
{
    static void Main()
    {
        Console.WriteLine("Please write down an integer number:");
        int p = 3;
        int n = int.Parse(Console.ReadLine());
        int nRightp = n >> p;
        int bit = nRightp & 1;

        Console.WriteLine("The 3-th bit of the number is {0}", bit);
    }
}

