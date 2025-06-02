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
            int lifes = 3;
            float a = 0;
            float b = 0;



            Random random = new Random();
            Console.WriteLine("Добро пожаловать в математический квиз!");
            Console.WriteLine("Напишие уровень сложности от 1 до 10");
            int level = int.Parse(Console.ReadLine());



            while (true)
            {
                a = random.Next(-10 * level,10 * level);
                b = random.Next(-10 * level, 10 * level);

                if (level > 5)
                {
                    a += (float)random.NextDouble();
                    b += (float)random.NextDouble();
                }

                Console.WriteLine($"{a} + {b} =\n");
                string answer = Console.ReadLine();

                if (a + b == float.Parse(answer))
                {
                    score++;
                    Console.WriteLine($"Правильный ответ!\nВаш счет:{score}");
                }
                else
                {
                    Console.WriteLine("Не правильно!");
                    lifes--;
                }

                if (lifes <= 0) 
                {
                    Console.WriteLine("Игра закончена!");
                    break;
                }
            }
            Console.WriteLine($"Вы проиграли! Вас счет {score}");
        }
    }
}
