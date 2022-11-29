using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _28_Nov
{
    internal class Program
    {
        class Car
        {
            public string Car_make;
            public string Typee;
            public int Year;
            public string Color;
            public string Model ;
            public int Price { set; get; }
            public int PalletNo { set; get; }

            public Car(string car_make, string type, int year, string color, string model, int price, int palletNo)
            {
                Car_make = car_make;
                Price = price;
                Model = model;
                Year = year;
                Typee = type;
                Color = color;
                PalletNo = palletNo;
            }
            public Car(){}
            public void TestReturn()
            {
                Console.WriteLine($" car_make : {Car_make}");
                Console.WriteLine($" Type  : {Typee}");
                Console.WriteLine($" Model : {Model}");
                Console.WriteLine($" color : {Color}");
                Console.WriteLine($" price : {Price}");
                Console.WriteLine($" Pallet.No : {PalletNo}");
                Console.WriteLine($" Year : {Year}");
            }

            public void start_end()
            {
                Console.Write("ON or OF");
                string x = Console.ReadLine();
                if (x == "ON") { Console.WriteLine("ven ven"); }
                else if(x== "OF") { Console.WriteLine("Z'zzzzzzzzzzzzzzzzzzzzz"); }

            }
            public void Conv()
            {
                Console.Write(" enter in liter");
                int x =Convert.ToInt32(Console.ReadLine())/20;
                
                Console.WriteLine($"{x}  k");

            }


        }
        class test : Car
        {
            //public test (string car_make, string type, int year, string color, string model, int price, int palletNo) : base (car_make, type, year, color, model, price, palletNo) ;
            public test(string car_make, string type, int year, string color, string model, int price, int palletNo)
            {
                Car_make = car_make;
                Price = price;
                Model = model;
                Year = year;
                Typee = type;
                Color = color;
                PalletNo = palletNo;
            }
            


        }

        static void Main(string[] args)
        {
            //Car obj=new Car("car_make", "Nissan", 2020, "red", "model", 1000, 5);
            test obj2 = new test("car_make", "Nissan", 2020, "red", "model", 1000, 5);
            obj2.TestReturn();
            obj2.start_end();
            obj2.Conv();
            
            
        }
    }
}
