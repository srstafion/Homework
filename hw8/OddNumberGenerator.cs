namespace NumberGenerators
{
    public sealed class OddNumberGenerator : NumberGenerator
    {
        private int current;

        public OddNumberGenerator()
        {
            current = 1;
        }

        public override int Next()
        {
            int number = current;
            current = number + 2;
            return number;
        }
    }
}
