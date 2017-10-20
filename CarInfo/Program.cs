using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Serena Tindle
            //October 20th 2017
            //Week 4 Assessment

            Console.WriteLine("Current Car Inventory");

            bool ContinueProgram = true;
            while (ContinueProgram == true)
            {
                Car Car1 = new Car("1112220", "Ford");
                Car Car2 = new Car("4443331", "Altima");
                NascarCAR NCar1 = new NascarCAR("3335551", "Chevy", "Heavy Chevy");
                NascarCAR NCar2 = new NascarCAR("7779995", "Chrysler", "Nicer Chrysler");
                NascarCAR NCar3 = new NascarCAR("4441112", "Jeep", "Beep Jeep");
                NascarCAR NCar4 = new NascarCAR("8887963", "Dodge", "Dodge Dodger");


                Car[] CarTypes = new Car[6];
                CarTypes[0] = Car1;
                CarTypes[1] = Car2;
                CarTypes[2] = NCar1;
                CarTypes[3] = NCar2;
                CarTypes[4] = NCar3;
                CarTypes[5] = NCar4;
                foreach(Car Element in CarTypes)
                {
                    Console.WriteLine(Element.Vin +""+ Element.Make);

                }

                string UserOption; //Continue program or exit?
                Console.WriteLine("Continue? (y/n)");
                UserOption = Console.ReadLine();

                if (UserOption == "N" || UserOption == "No" || UserOption == "no" || UserOption == "n" && UserOption != "yes" || UserOption != "y+")
                {
                    ContinueProgram = false;
                    Console.WriteLine("Have a good day!");
                }


                Console.ReadKey();
            }
        }
    }
}
