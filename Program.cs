﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Word ");
            String n1 = Console.ReadLine();
            Console.WriteLine("How Many Times ");
            int no1 = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= no1; i++)
            {
                Console.WriteLine("\n " + n1);
                Console.ReadLine();

            }
        }
    }
}
