using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            IsDivided(21);
            int count = OddAmount(20, 31);
            Console.WriteLine(count);
            int sum = OddSum(20, 25);
            Console.WriteLine(sum);
            IsSimpleOrComplex(121);
            int[] array = {1,2,3,4,5,6,7,8,9,10};
            EvenSum(array);
        }
        // Verilmiş n - ədədinin 3-ə və 7-ə bölünüb-bölünməməsini tapan metod
        static void IsDivided(int n)
        {
            if (n < 1) 
            {
                Console.WriteLine("Enter the correct number");
            }
            else if (n % 3 == 0 && n % 7 == 0)
            {
                Console.WriteLine("Number is divided to 3 and 7");
            }
            else
            {
                Console.WriteLine("Number is not divided to 3 and 7");
            }
        }
        // Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin sayini tapan metod
        static int OddAmount(int n, int m)
        {
            int count = 0;
            if (n < 1 || m < 1 )
            {
                Console.WriteLine("Enter the correct number");
            }
            else
            {
                for (int i = n; i < m; i++)
                {
                    if (i % 2 != 0)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        // Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin cemini tapan metod
        static int OddSum (int n, int m)
        {
            int sum = 0;
            if (n < 1 || m < 1)
            {
                Console.WriteLine("Enter the correct number");
            }
            else
            {
                for (int i = n; i < m; i++)
                {
                    if (i % 2 != 0)
                    {
                        sum += i;
                    }
                }
            }
            return sum;
        }
        // Verilmis n tam ededinin sade ve ya murekkeb oldugunu tapan metod
        static void IsSimpleOrComplex(int n)
        {
            int count = 0;
            if (n <= 1)
            {
                Console.WriteLine("Enter correct number");
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        count++;
                    }
                }
                if (count > 2)
                {
                    Console.WriteLine("Complex");
                }
                else
                {
                    Console.WriteLine("Simple");
                }
            }

        }
        // Verilmish arrayin icindeki cut ededlerin cemini tapan metod
        static void EvenSum(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    sum += array[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
