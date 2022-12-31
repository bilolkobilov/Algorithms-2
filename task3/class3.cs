using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework3_classes2
{
    class Student
    {
        public string Name;
        public int Age;
        public string Addres;
        public string Eaddres;

        public Student(string aName,int aAge, string aAddres, string aEaddres)
        {
            Name = aName;
            Age = aAge;
            Addres = aAddres;
            Eaddres = aEaddres;
        }
        public override string ToString()
        {
            return "Hello " + Name;
        }
    }
}
