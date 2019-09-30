namespace src
{
    public class CarFactory
    {
        public ICar GetCar(string type)
        {
            if (type == "Petrol")
            {
                return new PetrolCar();
            }

            if (type == "Electric")
            {
                return new ElectricCar();
            }

            return null;
        }
    }
}