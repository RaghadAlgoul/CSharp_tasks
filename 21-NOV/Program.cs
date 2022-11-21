using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_NOV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task1");
            Console.Write("enter first number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter secound number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2)
            {
                Console.WriteLine($"the bigger of two value is {num1} ");
            }
            else
            {
                Console.WriteLine($"the bigger of two value is {num2} ");
            }







            Console.WriteLine("Task2");
            Console.Write("enter the number");
            double number = Convert.ToDouble(Console.ReadLine());
            if (number > 0)
            {
                Console.WriteLine("+");
            }
            else
            {
                Console.WriteLine("-");
            }





            Console.WriteLine("Task3");
            Console.Write("enter first number");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("enter secound number");
            double number2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("enter third number");
            double number3 = Convert.ToDouble(Console.ReadLine());
            if (number1 > number2 && number1 > number3)
            {
                if (number2 > number3)
                {
                    Console.WriteLine($"{number1} > {number2}> {number3}");
                }
                else
                {
                    Console.WriteLine($"{number1} > {number3}> {number2}");
                }
            }
            else if (number2 > number1 && number2 > number3)
            {
                if (number1 > number3)
                {
                    Console.WriteLine($"{number2} > {number1}> {number3}");
                }
                else
                {
                    Console.WriteLine($"{number2} > {number3}> {number1}");
                }
            }
            else if (number3 > number1 && number3 > number2)
            {
                if (number1 > number2)
                {
                    Console.WriteLine($"{number3} > {number1}> {number2}");
                }
                else
                {
                    Console.WriteLine($"{number3} > {number2}> {number1}");
                }
            }









            Console.WriteLine("Task4");
            Console.Write("enter  number ");
            double v1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("enter number");
            double v2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("enter number");
            double v3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("enter number");
            double v4 = Convert.ToDouble(Console.ReadLine());
            Console.Write("enter number");
            double v5 = Convert.ToDouble(Console.ReadLine());
            if (v1 > v2 && v1 > v3 && v1 > v4 && v1 > v5)
            {
                Console.WriteLine($"max: {v1}");
            }
            else if (v2 > v1 && v2 > v3 && v2 > v4 && v2 > v5)
            {
                Console.WriteLine($"max: {v2}");
            }
            else if (v3 > v1 && v3 > v2 && v3 > v4 && v3 > v5)
            {
                Console.WriteLine($"max: {v3}");
            }
            else if (v4 > v1 && v4 > v2 && v4 > v3 && v4 > v5)
            {
                Console.WriteLine($"max: {v4}");
            }
            else if (v5 > v1 && v5 > v2 && v5 > v3 && v5 > v4)
            {
                Console.WriteLine($"max: {v5}");
            }



            Console.WriteLine("Task5");
            Console.Write("Input kilometers per hour:  ");
            double Knum = Convert.ToDouble(Console.ReadLine());
            double toMiles = Knum / 1.621371192;
            Console.WriteLine($"{toMiles} miles per hour");





            Console.WriteLine("Task6");
            Console.Write("Hours :");
            int hours = Convert.ToInt32(Console.ReadLine());
            Console.Write("Minutes :");
            double minutes = Convert.ToDouble(Console.ReadLine());
            double cal = (hours * 60) + minutes;
            Console.WriteLine($" The total of Minutes{cal}");








            Console.WriteLine("Task7");
            Console.Write("Minutes :");
            double minutesss = Convert.ToDouble(Console.ReadLine());
            int calculateHour = Convert.ToInt32(minutesss / 60);
            double calculateMinutes = minutesss % 60;
            Console.WriteLine($"{calculateHour} Hours,{calculateMinutes} Minutes ");



            Console.WriteLine("Task8");
            String[] arr = { "raghad", "mohammad ", "raneem", "bilal", "ahmad" };
            Console.WriteLine(arr[0].Substring(0, 3));
            Console.WriteLine(arr[1].Substring(0, 3));
            Console.WriteLine(arr[2].Substring(0, 3));
            Console.WriteLine(arr[3].Substring(0, 3));
            Console.WriteLine(arr[4].Substring(0, 3));


        }
    }
}
