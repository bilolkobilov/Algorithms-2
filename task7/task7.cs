using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework3_classes3
{
     class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("FG1000", "HONDA CIVIC", "SALE", 10000000, "Depreciation is $25000");
            Car car2 = new Car("GH7000", "Mercedez BClass", "Rental", 12500000, "NO. of days is 5 Rate");
            Car car3 = new Car("AY3000", "Bugatti Veyron", "Bus", 30000000, "Driver Cost $1000 bus");
            Car car4 = new Car("HI2000", "Nissan Sunny", "SALE", 7500000, "Depreciation is $6000");

            Console.WriteLine(car1.VehicleName);

            Console.ReadLine();
        }
    }
}
