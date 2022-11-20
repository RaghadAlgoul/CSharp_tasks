using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task1
            //Console.Write("enter your name ");
            //string name = Console.ReadLine();
            //Console.WriteLine(name);
            //task2
            //double DVar = 2.2;
            //Console.WriteLine(DVar);
            //string StrVar = "hi";
            //Console.WriteLine(StrVar);
            //char ChVar = 'a';
            //Console.WriteLine(ChVar);
            //bool BoolVar = true;
            //Console.WriteLine(BoolVar);
            //int IntVar = 2;
            //Console.WriteLine(IntVar);
            //const double ConstVar = 3.14;
            //Console.WriteLine(ConstVar);
            //Task3
            string[] arr = { " Hyundai", " Mitsubishi", " Toyota" };
            Console.WriteLine(arr[0]);
            Console.WriteLine(arr[1]);
            Console.WriteLine(arr[2]);
            Console.WriteLine(arr.Length);
            //Task4
            Console.Write("enter your First name ");
            string fname = Console.ReadLine();
            Console.Write("enter your last name ");
            string lname = Console.ReadLine();
            Console.Write("enter your birth year ");
            string Byear = Console.ReadLine();
            Console.Write(fname+ lname+ Byear);
            Console.WriteLine();
            //Task5
            int[] array = {0,1,2,3,4,5,6,7,8,9};
            Console.Write(array[0]);
            Console.Write(array[1]);
            Console.Write(array[2]);
            Console.Write(array[3]);
            Console.Write(array[4]);
            Console.Write(array[5]);
            Console.Write(array[6]);
            Console.Write(array[7]);
            Console.Write(array[8]);
            Console.WriteLine(array[9]);

            //Task6
            int[] array1 = { 0, 1, 2};
            Console.WriteLine(array[0]+ array[1]+ array[2]);




        }
    }
}
