using System;

namespace FactoryPatternExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello!  Based on the amount of tires you specify, we will create a new vehicle for you:");
            //Console.WriteLine($"How many tires do you want your vehicle to have?");

            //var userResponse = Console.ReadLine();

            //IVehicle userVehicle = VehicleFactory.GetVehicle(userResponse);

            //userVehicle.Drive();

            //Abstract Section-----------------------------------------------------
            Console.WriteLine("Lets create an abstract vehicle.  How many tires?");
            var abstractInput = Console.ReadLine();

            var abstractVehicle = VehicleFactory.GetAbstractVehicle(abstractInput);
            abstractVehicle.Drive();
        }
    }
}
