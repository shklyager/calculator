using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_100_calculate_last
{
    class Calculate
    {
        public static void Calculating(int[] items)
        {

            Console.Write("_____________\n\n Processing: ");
            if (items.Length == 3) //если пользователь выбрал два числа, то
            {
                if (items[0] == 1) //если была выбранна операция сложения
                {
                    Console.WriteLine("Sum= " + (items[1] + items[2])); //сложить два числа
                }
                if (items[0] == 2) //если была выбранна операция вычитания
                {
                    Console.WriteLine("Subtraction= " + (items[1] - items[2])); //вычесть из одного числа другое
                }
                if (items[0] == 3)//если была выбранна операция умножения
                {
                    Console.WriteLine("Increase= " + (items[1] * items[2]));//перемножить числа
                }
                if (items[0] == 4)//если была выбранна операция деления
                {
                    double div = (double)items[1] / (double)items[2];//разделить числа
                    Console.WriteLine("Division = " + Math.Round(div, 1));
                }
            }

            if (items.Length == 4)// тоже самое что и с двумя числами, только все операции выполняются с тремя числами
            {
                if (items[0] == 1)
                {
                    Console.WriteLine("Sum= " + (items[1] + items[2] + items[3]));
                }
                if (items[0] == 2)
                {
                    Console.WriteLine("Subtraction= " + (items[1] - items[2] - items[3]));
                }
                if (items[0] == 3)
                {
                    Console.WriteLine("Increase= " + (items[1] * items[2] * items[3]));
                }
                if (items[0] == 4)
                {
                    double div = (double)items[1] / (double)items[2] / (double)items[3];
                    Console.WriteLine("Division = " + Math.Round(div, 1));
                }
                Console.Write("_____________\n\n Processing: ");
            }
        }  //repair (conversion )
    }
}
