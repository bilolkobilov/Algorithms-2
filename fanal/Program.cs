using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static homework3_classes3_.Class3;

namespace homework3_classes3_
{
     class Program
    {
        static void Main(string[] args)
        {
            
            Student[] student1 = new Student[2];
           
            for (int i = 0; i < 2; i++)
            {
                Console.Write("Name: ");
                string name = Convert.ToString(Console.ReadLine());
                Console.Write("Age: ");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.Write("Address: ");
                string address = Convert.ToString(Console.ReadLine());
                Console.Write("Email: ");
                string email = Convert.ToString(Console.ReadLine());
                student1[i] = new Student(name, age, address, email);
                student1[i] = new Student(name, age, address, email);
            }
           

            Console.WriteLine(student1[0]);
            Console.WriteLine(student1[1]);

            Console.ReadLine();

        }
    }
}
