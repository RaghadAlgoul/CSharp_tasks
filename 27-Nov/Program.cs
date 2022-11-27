using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace _27_Nov
{
    internal class Program
    {
        public class MyClass
        {
            string Name;
            string Email;
            string Gender;
            string PhoneNum;
            int id;
            double Age;
            string subPhone;
            public MyClass(string name, int ID, double age, string email, string gender, string phoneNum)
            {
                Name = name;
                Email = email;
                Gender = gender;
                id = ID;
                Age = age;
                PhoneNum = phoneNum;
                subPhone = phoneNum.Substring(0, 3);
                
            }
            public string checkAge()
            {
                if (Age > 60 || Age < 18)
                {
                    return "sorry ,your age not match with condition";
                }
                else
                {
                    return Convert.ToString(Age);
                }

            }
            public string checkPhone()
            {

                if (subPhone == "077" || subPhone == "078" || subPhone == "079")
                {
                    return PhoneNum;

                }
                else
                {
                    return "sorry ,your phone number not match with condition";
                }

            }
            static void Main(string[] args)
            {
                MyClass obj = new MyClass("raghad", 2000, 19, "raghad@email", "female","0770555");
                Console.WriteLine(obj.Name);
                Console.WriteLine(obj.id);
                Console.WriteLine(obj.checkAge());
                Console.WriteLine(obj.Email);
                Console.WriteLine(obj.Gender);
                Console.WriteLine(obj.checkPhone());

            }





        }
    }
}


