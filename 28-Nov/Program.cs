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
            public string Car_make { set; get; }
            public string Typee { set; get; }
            public int Year { set; get; }
            public string Color { set; get; }
            public string Model { set; get; }
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
                string x = Console.ReadLine();
                if (x == "start") { Console.WriteLine("ven ven"); }
                else if(x=="end") { Console.WriteLine("Z'zzzzzzzzzzzzzzzzzzzzz"); }

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
            public test()
            {
               
            }


        }

        static void Main(string[] args)
        {
            //Car obj=new Car("car_make", "Nissan", 2020, "red", "model", 1000, 5);
            test obj2 = new test("car_make", "Nissan", 2020, "red", "model", 1000, 5);
            obj2.TestReturn();
            obj2.start_end();

            
            
        }
    }
}
