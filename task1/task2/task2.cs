using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework3_classes
{
     class Program
     {
        static void Main(string[] args)
        {
            //Create accessor and mutator methods for all attributes.
           
            Student student1 = new Student();
            student1.aName = "Bilol";
            student1.aAge = 18;
            student1.aAddres = "langar 2";
            student1.aEaddres = "qobilovbilol8222@gmail.com";

            Student student2 = new Student();
            student2.aName = "Begzod";
            student2.aAge = 20;
            student2.aAddres = "Faroboy 2";
            student2.aEaddres = "begzod001@email.com";

            Console.WriteLine(student1.aName);
            Console.ReadLine();

        }
     }
}