using System;
namespace FactoryPatternExercise
{
    public class Car : IVehicle
    {
        public Car()
        {
        }

        public Car(string input)
        {
            Console.WriteLine(input);
        }

        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} my car is now in drive.  ok..");
        }
    }
}
