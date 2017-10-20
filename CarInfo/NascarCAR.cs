using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInfo
{
    class NascarCAR: Car //inherit 'Car' class
    {
        //class member
        private string teamName; //add team name

        //property
        public string TeamName
        {
            set { teamName = value; }
            get { return teamName; }
        }
        
        //constructors
        public NascarCAR()
        {
            Vin = "";
            Make = "";
            TeamName = "";
        }
        public NascarCAR(string CarVIN, string CarMAKE, string TMname)
        {
            Vin = CarVIN;
            Make = CarMAKE;
            TeamName = TMname;
        }

        //method
        public override string PrintInfo()
        {

            return (Vin + "" + Make + ""+ TeamName);
        }
    }
}
