using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework3_classes3
{
    class Car
    {
        public string License;
        public string VehicleName;
        public string Category;
        public int Price;
        public string AddDate;

        public Car(string aLicense, string aVehicleName, string aCategory, int aPrice, string aAddData)
        {
            License = aLicense;
            VehicleName = aVehicleName;
            Category = aCategory;
            Price = aPrice;
            AddDate = aAddData;
        }
    }
}
