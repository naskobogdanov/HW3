using System;

class ExtractBitFromInteger
{
    static void Main()
    {
        Console.WriteLine("Please write down an integer number:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Please write down the bit position you want to extract:");
        int p = int.Parse(Console.ReadLine());
        int nRightp = n >> p;
        int bit = nRightp & 1;
        
        Console.WriteLine("The {1}-th bit of the number is {0}", bit, p);
    }
}

