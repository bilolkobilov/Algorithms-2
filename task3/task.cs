using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework3_classes2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Bilol", 19, "Langar 2", "qobilovb222@gmail.com");
            Console.WriteLine(student1.ToString());
            Console.ReadLine();
        }
    }
}