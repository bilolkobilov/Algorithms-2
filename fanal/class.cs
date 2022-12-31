using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace homework3_classes3_
{
    class Class3
    {
        public class Student
        {
            private String name;
            private int age;
            private String address;
            private String email;

            public Student(String Name, int Age, String Address, String Email)
            {
                name = Name;
                age = Age;
                address = Address;
                email = Email;
            }
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
                    return address;
                }
                set
                {
                    address = value;
                }
            }
            public string aEmail
            {
                get
                {
                    return email;
                }
                set
                {
                    email = value;
                }
            }
            public override string ToString()
            {
                return "Name-" + name + ",  Age-" + age + ",  Address-" + address + ",  Email-" + email + ".";
            }
        }
    }
}  