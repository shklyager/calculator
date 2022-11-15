using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_100_calculate_last
{
    class Program
    {
        static void Main(string[] args)
        {
            Repeat_collection.Repeat();
            while (true) //цикл в котором используется конструкция switch, пользователю задается вопрос желает ли он начать заново, и просят ввести y или n
            {
                string answer = Console.ReadLine(); 
                switch (answer)
                {
                    case "y"://если пользователь ввел y
                        {
                            Repeat_collection.Repeat();
                            Console.Write("Repeat, yes or no? Please input y/n: ");
                            break;
                        }
                    case "Y"://если пользователь ввел y
                        {
                            Repeat_collection.Repeat();
                            Console.WriteLine("Repeat, yes or no? Please input y/n:");
                            break;
                        }
                    case "n": //если пользователь ввел n
                        {
                            Console.WriteLine("GoodBye");//вывести GoodBye
                            break;
                        }
                    case "N"://если пользователь ввел N
                        {
                            Console.WriteLine("GoodBye");//вывести GoodBye
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Incorrect input!\nPlease input y/n:");//если пользоваетль ввел не верные значения
                            break;
                        }
                }
            }
        }  // repair (added looping)

    }
}
