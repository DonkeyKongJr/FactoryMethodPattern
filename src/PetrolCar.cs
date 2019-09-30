namespace src
{
    public class PetrolCar : ICar
    {
        public int Speed { get; private set; }

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