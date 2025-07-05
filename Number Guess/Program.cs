using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Guess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random sairaj = new Random();
            int num = sairaj.Next(1,100);

            bool key = false;

            Console.WriteLine("Welcome to the Number Guess Game...");
            
            do
            {
                Console.WriteLine("Please Guess the Number...");
                string input = Console.ReadLine();

                int inp = Convert.ToInt32(input);

                if (inp > num) 
                {
                    Console.WriteLine("Guess lower....");
                }
                else if (inp < num)
                {
                    Console.WriteLine("Guess higher....");
                }
                else if (inp == num)
                {
                    Console.WriteLine("You Win...");
                    key = true;
                }
            } 
            while (key == false);
            Console.WriteLine("Thank You");
            Console.ReadKey();
        }
    }
}
