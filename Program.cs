using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{

    internal class Program
    {
        static void Celolar()
        {
            int price0= 20;
            int price1= 30;
            int price2 = 50;
            int count0 = 0;
            int count1 = 0;
            int count2 = 0;
            int max;

            for (int i = 0; i <3; i++)
            {
                Console.WriteLine("what is your name");
                string name = Console.ReadLine();
                Console.WriteLine("chosse a package");
                int package = int.Parse(Console.ReadLine());

                if (package == 0)
                {
                    Console.WriteLine(name + " you need to pay " + price0);
                    count0++;
                    
                }
                else if (package == 1)
                {
                    Console.WriteLine(name + " you need to pay " + price1);
                    count1++;
                }
                else if (package == 2)
                {
                    Console.WriteLine(name + " you need to pay " + price2);
                    count2++;
                }
            }
            if (count0 > count1 && count0 >count2)
                max = count0;
            else if (count1 > count2 && count1 >count0)
                max = count1;
            else
                max = count2;

            if (max == count0)
                Console.WriteLine("the most popular package is package 0");
            else if (max == count1)
                Console.WriteLine("the most popular package is package 1");
            else
                Console.WriteLine("the most popular package is package 2");

        }
        
        static void Streak()
        {
            Console.WriteLine("enter a number");
            int num = int.Parse(Console.ReadLine());

            int maxstreak = 0;
            int currentstreak = 1;

            while (num > 0)
            {
                if (num % 10 == num / 10 % 10)
                    currentstreak++;

                else
                {
                    if (currentstreak > maxstreak)
                        maxstreak = currentstreak;
                    currentstreak = 1;
                }

                num = num / 10;
            }
            if (currentstreak > maxstreak)
                maxstreak = currentstreak;

            Console.WriteLine("the longer streak is " + maxstreak);
        }

        static void Secret()
        {
            Random rnd = new Random();
            int secretnum = rnd.Next(100);
            int num;
            int counter = 0;

            for (int i = 1; i <=3; i++)
            {
                Console.WriteLine("this is game " + i);
                do
                {
                    Console.WriteLine("enter a number");
                    num = int.Parse(Console.ReadLine());

                    if (num > secretnum)
                        Console.WriteLine("the number you chose is bigger than the secret number");
                    else if (num < secretnum)
                        Console.WriteLine("the number you chose is ssmaller than the secret number");


                    counter++;

                } while (num != secretnum);

                Console.WriteLine("you are right the number is " + secretnum + " you were right after " + counter + " times");
            }


        }
        static void Num()
        {
            Console.WriteLine("enter a number");
            int num = int.Parse(Console.ReadLine());
            int maxdigit = num % 10;
            num /= 10;

            while (num != 0)
            {
                int tempdigit = num % 10;
                if (tempdigit > maxdigit)
                    maxdigit = tempdigit;
                num /= 10;
            }
            Console.WriteLine("the max digit is" + maxdigit);
        }
        static void Main(string[] args)
        {
            Celolar();
        }
    }
}
