using System;

namespace src
{
    public class CarFactory
    {
        public ICar CreateCar(string type)
        {
            if (string.Equals(type, "Petrol", StringComparison.OrdinalIgnoreCase))
            {
                return new PetrolCar();
            }

            if (string.Equals(type, "Electric", StringComparison.OrdinalIgnoreCase))
            {
                return new ElectricCar();
            }

            throw new NotSupportedException($"Car Type '{type}' is not supported");
        }
    }
}