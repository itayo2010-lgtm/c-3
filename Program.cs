using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
         
        static void Food()
        {
            double a = 2.5;
            double b = 4.5;
            int c = 6;
            double price;
            double sum = 0;

            Console.WriteLine("how many cans are in the machine");
            int cans = int.Parse(Console.ReadLine());
            Console.WriteLine("how many snacks are in the machine");
            int snacks = int.Parse(Console.ReadLine());

            while (snacks > 5 &&  cans > 5)
            {
                Console.WriteLine("choose an option a, b or c");
                string choice =Console.ReadLine();
                Console.WriteLine("how many times do you want it up to 4");
                int times = int.Parse(Console.ReadLine());

                if (choice.Equals("a"))
                {
                    price = a * times;
                    snacks = snacks - times;
                }                  
                else if (choice.Equals("b"))
                {
                    price = b * times;
                    cans = cans - times;
                }                  
                else
                {
                    price = c * times;
                    snacks = snacks - times;
                    cans = cans - times;
                }                    
                sum += price;
            }
            Console.WriteLine("the total is " + sum + " there are " + snacks + " snacks left and there are " + cans + " cans left");
        }
        static void Snack()
        {
            int healthy = 0;
            int nothealthy = 0;
            double sum = 0;
            
            while (healthy  < 3)
            {
                Console.WriteLine("what is the snack name");
                string name = Console.ReadLine();
                Console.WriteLine("how many cals are in the snack");
                int cals = int.Parse(Console.ReadLine());
                Console.WriteLine("how many fat in grams there is in the snack");
                int fat = int.Parse(Console.ReadLine());

                if (cals < 130 && fat < 5)
                {
                    Console.WriteLine(name + " is healthy");
                    healthy += 1;
                }
                else
                {
                    Console.WriteLine(name + " is not healthy");
                    nothealthy += 1;
                }
                sum += 1;
            }
            Console.WriteLine("the total of snacks we checked is " + sum + " the part of healthy snacks out of all the snacks is " + (healthy / sum * 100));
        }
        static void Trip()
        {
            string lastname;
            int members;
            int cost = 100;
            int pay;
            int sum = 0;
            int families = 0;
            Console.WriteLine("how many people can go to the trip");
                int spots = int.Parse(Console.ReadLine());

            while (spots > 0)
            {
                Console.WriteLine("what is your family last name");
                lastname = Console.ReadLine();
                Console.WriteLine("how many members are in the family");
                members = int.Parse(Console.ReadLine());
                if (members <= spots)
                {
                    pay = members * cost;
                    sum += pay;
                    families++;
                    Console.WriteLine(lastname + " family you can go to the trip and you need to pay " + pay);
                    spots = spots - members;
                }
                else
                    Console.WriteLine(lastname + " family you cant go to the trip ther are not enugh spots for your family");
            }
            Console.WriteLine("there are " + families + " families that can go to the trip");
            Console.WriteLine("the total payment is " + sum);
        }
        static void Parking()
        {
            Console.WriteLine("how many parking spots are there");
            int spots = int.Parse(Console.ReadLine());
            int cantenter = 0;

            while (spots > 0)
            {
                Console.WriteLine("what is the car weight in tons");
                int w = int.Parse(Console.ReadLine());
                Console.WriteLine("what is the car hight in meters");
                int h = int.Parse(Console.ReadLine());
                if (w < 10 && h < 5)
                {
                    spots -= 1;
                    Console.WriteLine("you can enter");
                }

                else
                {
                    Console.WriteLine("you cant enter");
                    cantenter++;
                }
                    

            }
            if (cantenter > 0)
                Console.WriteLine("there are " + cantenter + " cars that cant enter");
            else
                Console.WriteLine("all of the cars can enter");
        }

         static void Celolar()
        {
            int price0 = 20;
            int price1 = 30;
            int price2 = 50;
            int count0 = 0;
            int count1 = 0;
            int count2 = 0;
            string mostpopular;
            int pay = 0;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("what is your name");
                string name = Console.ReadLine();
                Console.WriteLine("chosse a package 0, 1 0r 2");
                int package = int.Parse(Console.ReadLine());

                if (package == 0)
                {
                    pay = price0;
                    count0++;

                }
                else if (package == 1)
                {
                    pay = price1;
                    count1++;
                }
                else if (package == 2)
                {
                    pay = price2;
                    count2++;
                }
                Console.WriteLine(name + " you need to pay " + pay);
            }
            if (count0 > count1 && count0 > count2)
                mostpopular = "package 0";
            else if (count1 > count2 && count1 > count0)
                mostpopular = "package 1";
            else
                mostpopular = "package 2";

            Console.WriteLine("the most popular package is "+mostpopular);

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
            int attemps = 0;
            int maxattemps = 7;
            Console.WriteLine(secretnum);

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("this is game " + (i + 1));
                do
                {
                        Console.WriteLine("enter your guess between 0 to 100 be carfull you can guess " + (maxattemps - i) + " more times");
                        num = int.Parse(Console.ReadLine());

                    if (num > secretnum)
                        Console.WriteLine("the number you chose is bigger than the secret number");
                    else if (num < secretnum)
                        Console.WriteLine("the number you chose is ssmaller than the secret number");


                    attemps++;
                    i++;

                } while (num != secretnum && attemps<maxattemps);

                if (attemps > maxattemps)
                    Console.WriteLine("you are all out of attemps the corect number was " + secretnum);
                else
                    Console.WriteLine("congratulations you got it right after the " + attemps + "th try");
            }
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





