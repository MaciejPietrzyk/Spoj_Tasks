using System;
using System.Globalization;

class Program
{
    private static int n;

    static void Main()
    {
       
       int t = Convert.ToInt32(Console.ReadLine());
       
        for (int i = 0; i < t; i++)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] numbers = Console.ReadLine().Split(' ');
            int suma = 0;
            for(int j = 0; j < n; j++)
            {
                int a = Convert.ToInt32(numbers[j]);
                suma += a;
            }
            Console.WriteLine(suma);
        }

        

        Console.ReadLine();
    }
}