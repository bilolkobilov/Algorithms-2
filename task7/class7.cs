using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework3_classes3
{
    class Car
    {
        private string License;
        private string VehicleName;
        private string Category;
        private int Price;
        private string AddDate;

        public Car(string aLicense, string aVehicleName, string aCategory, int aPrice, string aAddData)
        {
            License = aLicense;
            VehicleName = aVehicleName;
            Category = aCategory;
            Price = aPrice;
            AddDate = aAddData;
        }
           public string aLicense
            {
                get
                {
                    return  License;
                }
                set
                {
                     License = value;
                }
            }
            public string aVehicleName
            {
                get
                {
                    return VehicleName;
                }
                set
                {
                    VehicleName = value;
                }
            }
            public string aCategory
            {
                get
                {
                    return Category;
                }
                set
                {
                    Category = value;
                }
            }
            public int aPrice
            {
                get
                {
                    return Price;
                }
                set
                {
                    Price = value;
                }
            }
            public string aAddData
            {
                get
                {
                    return  AddDate;
                }
                set
                {
                     AddDate = value;
                }
            }
        

    }
}
