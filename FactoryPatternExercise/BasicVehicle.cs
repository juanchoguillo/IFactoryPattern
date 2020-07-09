using System;
namespace FactoryPatternExercise
{
    public class BasicVehicle : Vehicle
    {
        public BasicVehicle()
        {
        }

        public override void Drive()
        {
            Console.WriteLine($"The type of vehicle you want does not yet exist");
        }
    }
}
