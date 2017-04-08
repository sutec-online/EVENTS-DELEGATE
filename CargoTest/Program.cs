using ClassLibrary;
using System;
using System.Threading;

namespace CargoTest
{
    class Program
    {
        static void Main(string[] args)
        {
            CargoVehicle arac1 = new CargoVehicle("42AB1234");
            CargoVehicle arac2 = new CargoVehicle("42AB1235", "Ford");

            arac1.SpeedExceeded += new CargoVehicle.SpeedHandler(speed_limit);
            arac2.SpeedExceeded += new CargoVehicle.SpeedHandler(speed_limit);
            
            for (byte i = 80; i < 130; i += 5)
            {
                arac1.Speed = i;
                arac2.Speed = (byte)(i + 20);
                Console.WriteLine(arac1.Plate + "'s speed = " + arac1.Speed);
                Console.WriteLine(arac2.Plate + "'s speed = " + arac2.Speed);
                Thread.Sleep(1000);
            }
        }

        public static void speed_limit(CargoVehicle vehicle)
        {
            Console.WriteLine(vehicle.Plate + " has exceed limits on "+DateTime.Now+" with " + vehicle.Speed + " speed.");
        }
    }
}
