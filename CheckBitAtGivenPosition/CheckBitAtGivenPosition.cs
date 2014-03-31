using System;

class CheckBitAtGivenPosition
{
    static void Main()
    {
        Console.WriteLine("Please write down an integer number:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Please write down the bit position you want to check:");
        int p = int.Parse(Console.ReadLine());
        int nRightp = n >> p;
        int bit = nRightp & 1;
        bool check = Convert.ToBoolean(bit);
        
        Console.WriteLine("bit @ p == 1 is {0}", check);
    }
}

