using System;
using System.Collections.Generic;
using System.Text;

namespace CAR
{
    class truck:Car
    {
        public List<String> truckList(truck Mynewtruck)
        {
            List<String> truckadd = new List<String>();
            truckadd.Add(Mynewtruck.make);
            string truckMake = Mynewtruck.make;

            truckadd.Add(Mynewtruck.model);
            string truckModel = Mynewtruck.model;

            truckadd.Add(Mynewtruck.colour);
            string truckColour = Mynewtruck.colour;

            return truckadd;
        }
    }
}
