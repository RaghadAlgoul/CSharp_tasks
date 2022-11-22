using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_NOV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Task1");
            //int[] ARR = { 1, 7, 9, 45 };
            //string[] arr2 = { "Str", "alex", "moh" };
            //string[] arr3 = { "the", "fox", "over", "lazy", "dog" };



            //Console.WriteLine("Task2");
            //string[] fruits = { "Tomato", "Banana", "Watermelon" };
            //Console.Write("the index of Banana : ");
            //Console.WriteLine(Array.IndexOf(fruits, "Banana"));
            //Console.Write("the index of Tomato : ");
            //Console.WriteLine(Array.IndexOf(fruits, "Tomato"));


            //Console.WriteLine("Task3");
            //string[] food = { "burger ", "shawerma ", "sandwesh ", "pizza ", "pasta " };
            //string[] sport = { "run ", "jump ", "football " };
            //string[] movie = { "movie1 ", "movie2 ", "movie3 ", "movie4 " };
            //Console.Write("My Favorite Food : ");
            //foreach (string i in food)
            //{
            //    Console.Write(i);
            //}
            //Console.WriteLine(" ");
            //Console.Write("My Favorite sport : ");
            //foreach (string i in sport)
            //{
            //    Console.Write(i);
            //}
            //Console.WriteLine(" ");
            //Console.Write("My Favorite movie : ");
            //foreach (string i in movie)
            //{
            //    Console.Write(i);
            //}
            //Console.WriteLine(" ");




            //Console.WriteLine("Task4");
            //Console.Write("enter three number");
            //string userInput = Console.ReadLine();
            //String[] spearator = { "," };
            //Int32 count = 3;

            //// using the method
            //String[] strlist = userInput.Split(spearator, count,
            //       StringSplitOptions.RemoveEmptyEntries);
            //int sumStringOfArray = 0;
            //foreach (String s in strlist)
            //{
            //    sumStringOfArray += Convert.ToInt32(s);
            //}
            //Console.WriteLine($"the sum of three item is : {sumStringOfArray}");



            //Console.WriteLine("Task5");
            //string oddArray= "1";
            //int ssum = 0;
            //for (int i = 2; i <= 100; i++)
            //{
            //    if( i % 2 == 1) {
            //        string x = Convert.ToString(i);
            //        oddArray += $", {i}";
            //        ssum += i;
            //    }
            //}
            //Console.WriteLine($"The odd numbers are {oddArray}");
            //Console.WriteLine($"The sum of odd numbers are {ssum}");



            Console.WriteLine("Task6");
            int space1 = 4;
            for(int i=0; i<5; i++)
            {
                string str = new string(' ', space1);
                Console.Write(str);
                for (int j = 0; j <i; j++)
                {
                    Console.Write("* ");
                }
                Console.Write(str);
                Console.WriteLine("");
                space1 -= 1;
            }


            Console.WriteLine("Task7");
            int space2 = 4;
            int num = 1;
            for (int i = 1; i < 5; i++)
            {
                string str = new string(' ', space2);
                Console.Write(str);
                for (int j = 0; j < i; j++)
                {
                    string intToString = Convert.ToString(num);
                    Console.Write(intToString+" ");
                    num += 1;
                }
                Console.Write(str);
                Console.WriteLine("");
                space2 -= 1;
            }



           

        }
    }
}
