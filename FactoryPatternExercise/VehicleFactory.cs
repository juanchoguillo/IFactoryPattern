using System;
namespace FactoryPatternExercise
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(string userInput)
        {
            switch (userInput)
            {
                case "18":
                    return new BigRig();
                case "4":
                    return new Car();
                case "3":
                    return new ThreeWheeler();
                default:
                    return new Car("This is a basic car");
            }
        }

        public static Vehicle GetAbstractVehicle(string userInput)
        {
            switch (userInput)
            {
                case "2":
                    return new Motorcycle();
                case "6":
                    return new Bus();
                default:
                    return new BasicVehicle();
            }
        }

    }
}
