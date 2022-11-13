using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGB_HW13
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int number = rand.Next(1,10000000);
            Console.WriteLine("Случайное число: " + number);
            if (number < 100)
            {
                Console.WriteLine("Третьей цифры нет!");
            }
            else
            {
                bool n = true;
                while(n)    //сокращаем число до 3-х разрядов
                {
                    if (number > 1000)
                    {
                        number = number / 10;
                    }
                    else
                    {
                        n = false; 
                    }
                }
                int result = number - (number / 100) * 100 - (((number % 100) / 10) * 10);
                Console.WriteLine("Третья цифра заданного числа равна: " + result);
            }
        }
    }
}
