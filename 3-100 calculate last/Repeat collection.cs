using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_100_calculate_last
{
    class Repeat_collection
    {
        public static void Repeat()
        {
            int inputChoise = User_interface.UserInterface();
            int inputOperation = Choosing_an_operation.ChoosingAnOperation();
            int[] numbReturn = Determining_numbers.WhatNumbers(inputChoise, inputOperation);
            Calculate.Calculating(numbReturn);
            Console.WriteLine("\n -----End-----"); //вывести -----End-----
            Console.WriteLine("Repeat, yes or no? Please input y/n:");//вывести Repeat, yes or no? Please input y/n:
        }  //updait (added method)
    }
}
