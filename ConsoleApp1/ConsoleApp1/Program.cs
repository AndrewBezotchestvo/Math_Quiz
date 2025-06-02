using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int score = 0;
            int record = 0;
            int a = 0;
            int b = 0;

            Random random = new Random();

            while (true)
            {
                a = random.Next(0,10);
                b = random.Next(0,10);

                Console.WriteLine($"{a} + {b} =\n");
                string answer = Console.ReadLine();

                if (a + b == int.Parse(answer))
                {
                    score++;
                    Console.WriteLine($"Правильный ответ!\nВаш счет:{score}");
                }
                else
                {
                    Console.WriteLine("Не правильно!");
                }

            }
        }
    }
}
