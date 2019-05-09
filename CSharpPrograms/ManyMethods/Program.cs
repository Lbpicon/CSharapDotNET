using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyMethodds
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static void hello()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Bye " + name);
            Console.Read();
        }

        public static void addition(int num11, int num32)
        {
            Console.WriteLine("Please enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second number: ");
            int sum2 = int.Parse(Console.ReadLine());
            int sum = num11 + num32;
            Console.WriteLine("The sum is " + sum);
            Console.Read();

        }

        public static void oddEvent()
        {
            int i;
            Console.Write("Please Enter a Number :");
            bool isNum = int.TryParse(Console.ReadLine(), out i);
            if (isNum)
            {
                if (i % 2 == 0)
                {
                    Console.Write("Entered Number is an Even Number");
                }
                else
                {
                    Console.Write("Entered Number is an Odd Number");
                }
            }
            else
            {
                Console.Write("It is not a Number!");
            }
        }



        class MainClass
        {
            public static void inches(string[] args)
            {
                Console.WriteLine("Please enter inches:");
                double inches = Convert.ToDouble(Console.ReadLine());
                double feet = inches / 12;
                Console.WriteLine(feet + "Feet");
            }

        }
    }
}





