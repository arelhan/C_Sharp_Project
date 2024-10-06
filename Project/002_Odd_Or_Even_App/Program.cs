using System;

public class OddOrEven {
    public static void Main(String[] args)
    {
        int s1=0;
        Console.Write("Please insert a number : ");
        s1 = Convert.ToInt32(Console.ReadLine());
        if (s1 % 2 ==0)
        {
            Console.WriteLine("The number is odd");
        }
        else
        {
            Console.WriteLine("The number is even");
        }
        Console.ReadKey();
    }
}