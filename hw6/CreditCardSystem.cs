namespace CreditCardSystem
{
    public class CreditCard
    {
        public string CardNumber { get; set; }
        public int Balance { get; set; }

        public CreditCard(string CardNumber, int Balance)
        {
            CardNumber = CardNumber;
            Balance = Balance;
        }

        public static CreditCard operator +(CreditCard CreditCard, int increase)
        {
            if (increase < 0)
                throw new ArgumentException("Increase amount cannot be negative");
            return new CreditCard(CreditCard.CardNumber, CreditCard.Balance + increase);
        }

        public static CreditCard operator -(CreditCard CreditCard, int decrease)
        {
            if (decrease < 0)
                throw new ArgumentException("Decrease amount cannot be negative");
            return new CreditCard(CreditCard.CardNumber, CreditCard.Balance - decrease);
        }

        public static bool operator ==(CreditCard CreditCard1, CreditCard CreditCard2)
        {
            if (ReferenceEquals(CreditCard1, null) && ReferenceEquals(CreditCard2, null))
                return true;
            if (ReferenceEquals(CreditCard1, null) || ReferenceEquals(CreditCard2, null))
                return false;
            return CreditCard1.Balance == CreditCard2.Balance;
        }

        public static bool operator !=(CreditCard CreditCard1, CreditCard CreditCard2)
        {
            return !(CreditCard1 == CreditCard2);
        }

        public static bool operator <(CreditCard CreditCard1, CreditCard CreditCard2)
        {
            return CreditCard1.Balance < CreditCard2.Balance;
        }

        public static bool operator >(CreditCard CreditCard1, CreditCard CreditCard2)
        {
            return CreditCard1.Balance > CreditCard2.Balance;
        }

        public class Comparer : IEqualityComparer<CreditCard>
        {
            public static Comparer Instance { get; } = new Comparer();

            private Comparer() { }

            public bool Equals(CreditCard x, CreditCard y)
            {
                if (x == null || y == null)
                    return false;

                return x.CardNumber == y.CardNumber && x.Balance == y.Balance;
            }

            public int GetHashCode(CreditCard obj)
            {
                if (obj == null)
                    return 0;

                return HashCode.Combine(obj.CardNumber, obj.Balance);
            }
        }
    }
}
