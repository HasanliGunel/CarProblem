using System;
using System.Collections.Generic;
using System.Text;

namespace CAR
{
    class motorbike:Car
    {
        public List<String> bikeList(motorbike Mynewbike)
        {
            List<String> bikeadd = new List<String>();
            bikeadd.Add(Mynewbike.model);
            string bikeModel = Mynewbike.model;

            bikeadd.Add(Mynewbike.make);
            string bikeMake = Mynewbike.make;

            bikeadd.Add(Mynewbike.colour);
            string bikeColour = Mynewbike.colour;

            return bikeadd;
        }
    }
}
