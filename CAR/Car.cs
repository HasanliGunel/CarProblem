using System;
using System.Collections.Generic;
using System.Text;

namespace CAR
{
    class Car
    {
        public string make { get; set; }
        public string model { get; set; }
        public string colour { get; set; }

        public List<String> carList(Car Mynewcar)
        {
            List<String> caradd = new List<String>();
            caradd.Add(Mynewcar.make);
            string carMake = Mynewcar.make;

            caradd.Add(Mynewcar.model);
            string carModel = Mynewcar.model;

            caradd.Add(Mynewcar.colour);
            string carColour = Mynewcar.model;


            return caradd;
        }
    }
}
