using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework3_classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Bilol", 18, "langar 2", "qobilovbilol8222@gmail.com");

            Console.WriteLine(student1.name);
            Console.ReadLine();

        }
    }
}
