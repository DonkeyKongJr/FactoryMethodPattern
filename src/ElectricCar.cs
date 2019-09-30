namespace src
{
    public class ElectricCar : ICar
    {
        public int Speed { get; private set; }

        public string GetName()
        {
            return "Electric";
        }

        public void Accelerate()
        {
            Speed = Speed + 2;
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