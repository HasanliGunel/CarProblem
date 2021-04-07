using System;

namespace CAR
{
    static class Program
    {
        static void Main(string carMake, string carModel, string carColour, string bikeModel, string bikeMake, string bikeColour, string truckMake, string truckModel, string truckColour)
        {
            Car Mynewcar = new Car();
            motorbike Mynewbike = new motorbike();
            truck Mynewtruck = new truck();

            int choice = 0;
            while (choice != 5)
            {

                Console.WriteLine("MENU");
                Console.WriteLine("What service do you need");
                Console.WriteLine("1. Car");
                Console.WriteLine("2. Motorbike");
                Console.WriteLine("3. Truck");
                Console.WriteLine("4. Search");
                Console.WriteLine("5. Exit");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("What is the car make?");
                        Mynewcar.make = Console.ReadLine().ToLower();
                        carMake = Console.ReadLine();
                        Console.WriteLine("");

                        Console.WriteLine("What is the car model?");
                        Mynewcar.model = Console.ReadLine().ToLower();
                        carModel = Console.ReadLine();
                        Console.WriteLine("");

                        Console.WriteLine("What is the car Colour?");
                        Mynewcar.colour = Console.ReadLine().ToLower();
                        carColour = Console.ReadLine();
                        Console.WriteLine("");

                        break;
                    case 2:
                        Console.WriteLine("what is the motorbike make");
                        Mynewbike.make = Console.ReadLine().ToLower();
                        bikeMake = Console.ReadLine();
                        Console.WriteLine("");

                        Console.WriteLine("what is the motorbike model");
                        Mynewbike.model = Console.ReadLine().ToLower();
                        bikeModel = Console.ReadLine();
                        Console.WriteLine("");

                        Console.WriteLine("what is the motorbike colour");
                        Mynewbike.colour = Console.ReadLine().ToLower();
                        bikeColour = Console.ReadLine();
                        Console.WriteLine("");

                        break;
                    case 3:
                        Console.WriteLine("what is the trucks make");
                        Mynewtruck.make = Console.ReadLine().ToLower();
                        truckMake = Console.ReadLine();
                        Console.WriteLine("");

                        Console.WriteLine("what is the trucks model");
                        Mynewtruck.model = Console.ReadLine().ToLower();
                        truckModel = Console.ReadLine();
                        Console.WriteLine("");

                        Console.WriteLine("what is the trucks colour");
                        Mynewtruck.colour = Console.ReadLine().ToLower();
                        truckColour = Console.ReadLine();
                        Console.WriteLine("");

                        break;
                    case 4:
                        string searchchoice = "";
                        Console.WriteLine("select Car, Motobike or truck to search?");
                        searchchoice = Console.ReadLine().ToLower();
                        if (searchchoice.Equals("car"))
                        {
                            Console.WriteLine("Car in inventory: {0} - {1} - {2}", carMake, carModel, carColour);
                        }
                        else if (searchchoice.Equals("motorbike"))
                        {
                            Console.WriteLine("Motorbike in inventory: {0} - {1} - {2}", bikeMake, bikeModel, bikeColour);
                        }
                        else
                        {
                            Console.WriteLine("Trucks in inventory: {0} - {1} - {2}", truckMake, truckModel, truckColour);
                        }
                        Console.ReadLine();
                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("Sorry, invalid selection");
                        break;
                }
            }
        }
    }
}
