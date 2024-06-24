namespace NumberGenerators
{
    public sealed class EvenNumberGenerator : NumberGenerator
    {
        private int current;

        public EvenNumberGenerator()
        {
            current = 0;
        }

        public override int Next()
        {
            int number = current;
            current = number + 2;
            return number;
        }
    }
}
