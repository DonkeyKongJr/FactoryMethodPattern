namespace src
{
    public class PetrolCar : ICar
    {
        public int Speed { get; private set; }

        public string GetName()
        {
            return "Petrol";
        }

        public void Accelerate()
        {
            Speed++;
        }

        public void Break()
        {
            if (Speed > 0)
            {
                Speed--;
            }
        }
    }
}