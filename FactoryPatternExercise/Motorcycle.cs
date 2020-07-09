using System;
namespace FactoryPatternExercise
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle()
        {
            WheelCount = "2";
        }

        public override void Drive()
        {
            Console.WriteLine($"{GetType().Name} is ready.  Your new name is Maverick.");
        }
    }
}
