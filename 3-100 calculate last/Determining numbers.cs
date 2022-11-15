using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_100_calculate_last
{
    class Determining_numbers
    {
        public static int[] WhatNumbers(int a, int b)
        {
            int oper = b;
            int choise = a;
            if (choise == 2) //если переменная choise = 2, тоесть пользователь выбрал вначале 2 числа, то
            {
                Console.Write("Please input number 1: "); //нужно ввести первое число
                int number1;
                string input1 = Console.ReadLine();
                bool result1 = int.TryParse(input1, out number1);
                if (result1 == true)
                {
                    while (number1 < 0 || number1 > 2300000) // пока это число <0 или >2300000, то будет работать цикл
                    {
                        Console.WriteLine("Incorrect input, please input again"); // выводится Incorrect input, please input again
                        int.TryParse(Console.ReadLine(), out number1);
                    }
                }
                Console.Write("Please input number 2: "); //нужно ввести второе число

                int number2;
                string input2 = Console.ReadLine();
                bool result2 = int.TryParse(input2, out number2);
                if (result2 == true)
                {
                    while (number2 < 0 || number2 > 2300000) // пока это число <0 или >2300000, то будет работать цикл
                    {
                        Console.WriteLine("Incorrect input, please input again"); // выводится Incorrect input, please input again
                        int.TryParse(Console.ReadLine(), out number2);
                    }
                }

                int[] numbReturn = new int[] { oper, number1, number2 };
                return numbReturn;
            }

            if (choise == 3) //если пользователь вначале выбрал 3 числа, то происходит все тоже самое, что и с двумя числами, только тут нужно ввести три чилса
            {
                Console.Write("Please input number 1: ");
                int number3;
                int.TryParse(Console.ReadLine(), out number3);
                while (number3 < 0 || number3 > 2300000)
                {
                    Console.WriteLine("Incorrect input, please input again");
                    int.TryParse(Console.ReadLine(), out number3);
                }
                Console.Write("Please input number 2: ");
                int number4;
                int.TryParse(Console.ReadLine(), out number4);
                while (number4 < 0 || number4 > 2300000)
                {
                    Console.WriteLine("Incorrect input, please input again");
                    int.TryParse(Console.ReadLine(), out number4);
                }
                Console.Write("Please input number 3: ");
                int number5;
                int.TryParse(Console.ReadLine(), out number5);
                while (number5 < 0 || number5 > 2300000)
                {
                    Console.WriteLine("Incorrect input, please input again");
                    int.TryParse(Console.ReadLine(), out number5);
                }
                int[] numbReturn = new int[] { oper, number3, number4, number5 };
                return numbReturn;
            }

            else
            {
                int bag = 0;
                int bag1 = 0;
                int[] numbReturn = new int[] { bag, bag1 };
                return numbReturn;
            }
        }
    }
}
