using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_100_calculate_last
{
    class User_interface
    {
        public static int UserInterface()
        {
            Console.Write("\nHello user, how many numbers need to be counted (2 or 3): "); // вывод на экран вопроса сколько чисел нужно сосчитать
            int inputChoise;
            int.TryParse(Console.ReadLine(), out inputChoise);
            while (inputChoise < 1 || inputChoise > 3) // цикл while будет работать пока введенное число <1 или >3
            {
                Console.WriteLine("Incorrect input, please input again"); //вывод надписи Incorrect input, please input again(не правильно введены данные, попробуйте еще раз)
                int.TryParse(Console.ReadLine(), out inputChoise);
            }
            return inputChoise;
        }
    }
}
