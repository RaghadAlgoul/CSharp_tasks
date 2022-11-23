using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //sum of 10 input number
            //Console.WriteLine("enter 10 numbers");
            //Task1();


            //Console.Write("years grater than 1950 : ");
            //Task2(Convert.ToInt32(Console.ReadLine()));

            // cube
            //Task3();

            //age(years-> days)
            //Console.Write("enter your age");
            //int age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"the age in years :{age} and equal :{Task4(age)} in days ");


            //animals legs 
            //Console.Write("number of chickens :");
            //int chickens = Convert.ToInt32(Console.ReadLine());
            //Console.Write("number of cows :");
            //int cows = Convert.ToInt32(Console.ReadLine());
            //Console.Write("number of pigs :");
            //int pigs = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(Task5(chickens, cows, pigs));


            //log in
            //Console.Write("enter username");
            //string username =Console.ReadLine();
            //Console.Write("enter password");
            //int password = Convert.ToInt32(Console.ReadLine());
            //Task6(username,password);

            //power
            //Console.Write("enter number");
            //int number = Convert.ToInt32(Console.ReadLine());
            //Console.Write("enter power");
            //int pow = Convert.ToInt32(Console.ReadLine());
            //Task7(number, pow);

            //leap year
            //Console.WriteLine("leap year");
            //Task8();
            //int number = Convert.ToInt32(Console.ReadLine());
            //Task9(number);

            Task10(Console.ReadLine());
        }
        static void Task1()
        {
            int sum = 0;

            for(int i = 0; i < 10; i++)
            {
                int inputValue=Convert.ToInt32(Console.ReadLine());
                sum += inputValue;
            }
            int avg = sum / 10;
            Console.WriteLine($"The sum of 10 no is :{sum}");
            Console.WriteLine($"The Average  of 10 no is :{avg}");
        }



        static void Task2(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                int cube = i * i * i;
                Console.WriteLine($"Number is : {i} and cube of the {i} is :{cube}");
            }
        }




        
       static void Task3()
        {
            int[] years = {1763, 1972, 1925, 1916, 1984, 1124, 1950, 2020};
            for (int i = 1; i < years.Length; i++)
            {
                if (years[i] > 1950)
                {
                    Console.WriteLine(years[i]);

                }
            }

        }



        static int Task4(int num)
        {
            return num * 361;
        }


        static int Task5(int chickens,int cows,int pigs)
        {
            return (chickens * 2) + (cows*4) + (pigs*4);
        }


        static void Task6(string username, int password)
        {
            string[] names = {"raghad","raneem","ahmad"};
            int[] pass = { 2000, 2007,2013 };
            for (int i = 0; i < names.Length; i++)
            {
                if(names[i]==username && pass[i]== password)
                {
                    Console.WriteLine("success login");
                    break;
                }
                else if (i == names.Length-1)
                {
                    Console.WriteLine("faild login");
                   
                }
            }

        }


        static void Task7(int num,int pow)
        {
            int x = 1;
            for (int i = 0; i < pow; i++)
            { 
                x *= num;
            }
            Console.WriteLine($"power is : {x}");

        }



        static void Task8()
        {
            List<int> arr = new List<int>();
            arr.Add(0);
            for (int i = 1901; i < 2025; i++)
            {
                
                if (i % 4 == 0)
                {
                    arr.Add(i);
                }
            }
            for (int i = 1; i < arr.Count; i++)
            {
                Console.WriteLine(arr[i]);
            }

        }

        static void Task9(int num)
        {
            List<int> arr = new List<int>();
            
            for (int i = 2; i < 10; i++)
            {
                if (num % i == 0)
                {
                    arr.Add(i);
                }
            }
            if (arr.Count == 1)
            {
                if (arr[0] == num) {
                    Console.WriteLine(" prime");
                }
                
            }
            else
            {
                Console.WriteLine("not prime");
            }




        }


        static void Task10(string str) {
            int sum = 0;
            foreach (char i in str)
            {
                if ( i==' ')
                {
                    sum += 1;
                }
                

            }
            Console.WriteLine($"number of word : {sum + 1}");
        }

    }
}

