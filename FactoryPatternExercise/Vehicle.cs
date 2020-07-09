using System;
namespace FactoryPatternExercise
{
    public abstract class Vehicle
    {
        public string WheelCount { get; set; }

        public abstract void Drive();

        public virtual void BasicDefault()
        {
            Console.WriteLine($"The type of vehicle you want does not yet exist");
        }
    }
}
