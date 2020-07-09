using System;
namespace FactoryPatternExercise
{
    public class Bus : Vehicle
    {
        public Bus()
        {
            WheelCount = "6";
        }

        public override void Drive()
        {
            Console.WriteLine($"The wheels on the {GetType().Name} go round and round");
        }
    }
}
