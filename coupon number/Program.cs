using System;

namespace CouponNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int count = 30;
            int[] numbers = new int[count];
            for (int i = 0; i < count; i++)
            {

                numbers[i] = rnd.Next(1, 100);
                Console.WriteLine("random number generate= " + numbers[i]);
            }

            Console.WriteLine("Enter a coupon number ");
            int N1 = int.Parse(Console.ReadLine());

            int index;
            bool flag = false;
            for (int i = 1; i < 30; i++)
            {
                if (numbers[i] == N1)
                {
                    index = i;
                    Console.WriteLine("index of that Number is " + i);
                    flag = true;
                    break;

                }
            }
            if (flag)
            {
                Console.WriteLine("is found " + N1);

            }
            else
            {
                Console.WriteLine("is number is not found" + N1);
            }



        }
    }
}
