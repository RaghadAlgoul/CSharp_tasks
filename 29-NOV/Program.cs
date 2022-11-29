using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _29_N
{
    internal class Program
    {
        class Employee
        {
            public string Name;
            public int  D_of_birth;
            public int ID;
            

            public Employee(string name, int birth,int id)
            {
                Name = name;
                D_of_birth = birth;
                ID = id;
            }
            public Employee() { }
            public void Age() {
                int age = 2022 - D_of_birth;
                Console.WriteLine($"the age is : {age} ");

            }
            public virtual void TestReturn()
            {
            }




        }
        class Manager : Employee
        {
            public Manager(string name, int birth, int id)
            {
                Name = name;
                D_of_birth = birth;
                ID = id;

            }
            public override void TestReturn()
            {
                Console.WriteLine($" Name : {Name}");
                Console.WriteLine($" ID : {ID}");
                Age();
                
            }
            



        }

        static void Main(string[] args)
        {
            //Car obj=new Car("car_make", "Nissan", 2020, "red", "model", 1000, 5);
            Manager obj2 = new Manager("raghad", 2000, 2000);
            obj2.TestReturn();
            


        }
    }
}

