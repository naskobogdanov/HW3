using System;

class ModifyBitAtGivenPosition
{
    static void Main()
    {
        Console.WriteLine("Please write down an integer number:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Please write down the bit position you want to change:");
        int p = int.Parse(Console.ReadLine());
        Console.WriteLine("Please write down the value to change:");
        int v = int.Parse(Console.ReadLine());
        bool newnumber = Convert.ToBoolean(v);
        
        if (v <= 1 && v >= 0)
        {
            if (newnumber == false)
            {
                int mask0 = ~(1 << p);
                int result0 = n & mask0;
                Console.WriteLine("The {0}-th bit is changed to {1}, and the result is {2}", p, v, result0);
            }
            
            if (newnumber == true)
            {
                int mask1 = 1 << p;
                int result1 = n | mask1;
                Console.WriteLine("The {0}-th bit is changed to {1}, and the result is {2}", p, v, result1);
            }
            
            
        }
        else 
        {
            Console.WriteLine("Not a valid bit value!!!");
        }
    }
}
