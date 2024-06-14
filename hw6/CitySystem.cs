namespace CitySystem
{
    public class City
    {
        public string Name { get; set; }
        public int Population { get; set; }

        public City(string name, int population)
        {
            Name = name;
            Population = population;
        }

        public static City operator +(City city, int increase)
        {
            if (increase < 0)
                throw new ArgumentException("Increase amount cannot be negative");
            return new City(city.Name, city.Population + increase);
        }

        public static City operator -(City city, int decrease)
        {
            if (decrease < 0)
                throw new ArgumentException("Decrease amount cannot be negative");
            return new City(city.Name, city.Population - decrease);
        }

        public static bool operator ==(City city1, City city2)
        {
            if (ReferenceEquals(city1, null) && ReferenceEquals(city2, null))
                return true;
            if (ReferenceEquals(city1, null) || ReferenceEquals(city2, null))
                return false;
            return city1.Population == city2.Population;
        }

        public static bool operator !=(City city1, City city2)
        {
            return !(city1 == city2);
        }

        public static bool operator <(City city1, City city2)
        {
            return city1.Population < city2.Population;
        }

        public static bool operator >(City city1, City city2)
        {
            return city1.Population > city2.Population;
        }

        public class Comparer : IEqualityComparer<City>
        {
            public static Comparer Instance { get; } = new Comparer();

            private Comparer() { }

            public bool Equals(City x, City y)
            {
                if (x == null || y == null)
                    return false;

                return x.Name == y.Name && x.Population == y.Population;
            }

            public int GetHashCode(City obj)
            {
                if (obj == null)
                    return 0;

                return HashCode.Combine(obj.Name, obj.Population);
            }
        }
    }
}
