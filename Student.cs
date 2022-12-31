using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework3_classes
{
      public class Student
      {
        private string name;
        private int age;
        private string addres;
        private string eaddres;

        public String aName
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }      
        public int aAge
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        public string aAddres
        {
            get
            {
                return addres;
            }
            set
            {
                addres = value;
            }
        }
        public string aEaddres
        {
            get
            {
                return eaddres;
            }
            set
            {
                eaddres = value;
            }
        }        
      }
}
