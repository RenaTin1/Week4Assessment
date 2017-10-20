using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInfo
{
    class Car
    {
        //class members
        private string vin;
        private string make;

        //properties
        public string Vin
        {
            set { vin = value; }
            get { return vin; }
        }
        public string Make
        {
            set { make = value;}
            get {return make;}
        }

        //constructors
        public Car()
        {
            Vin = "";
            Make = "";
        }
       public Car(string CarVIN, string CarMAKE)
        {
            Vin = CarVIN;
            Make = CarMAKE;
        }
        //method
        public virtual string PrintInfo()
        {

            return (Vin + "" + Make + "");
        }

    }





}
