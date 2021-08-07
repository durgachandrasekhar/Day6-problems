using System;

namespace Perfectnumber
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n, i, sum;
            int n1, n2;
            Console.Write("Find perfect numbers within a given number of range :");
            Console.WriteLine("Enter the starting range of number :");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the ending range of number:");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Perfect numbers within the given range :");
            for (n = n1; n <= n2; n++)
            {
                i = 1;
                sum = 0;
                while (i < n)
                {
                    if (n % i == 0)
                        sum = sum + i;
                    i++;
                }

                if (sum == n)
                    Console.WriteLine("{0} ", n);
                else
                    Console.WriteLine("It is not a perfect number");
            } 
           

           
        }
    }
}

