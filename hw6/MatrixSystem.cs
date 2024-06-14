namespace MatrixSystem
{
    public class Matrix
    {
        private readonly double[,] data;
        public int Rows { get; set; }
        public int Columns { get; set; }

        public double this[int row, int col]
        {
            get { return data[row, col]; }
            set { data[row, col] = value; }
        }

        public Matrix(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
            data = new double[rows, columns];
        }

        public static Matrix operator +(Matrix a, Matrix b)
        {
            if (a.Rows != b.Rows || a.Columns != b.Columns)
                throw new ArgumentException("Matrices must have the same dimensions for addition.");

            Matrix result = new Matrix(a.Rows, a.Columns);
            for (int i = 0; i < a.Rows; i++)
            {
                for (int j = 0; j < a.Columns; j++)
                {
                    result[i, j] = a[i, j] + b[i, j];
                }
            }
            return result;
        }

        public static Matrix operator -(Matrix a, Matrix b)
        {
            if (a.Rows != b.Rows || a.Columns != b.Columns)
                throw new ArgumentException("Matrices must have the same dimensions for subtraction.");

            Matrix result = new Matrix(a.Rows, a.Columns);
            for (int i = 0; i < a.Rows; i++)
            {
                for (int j = 0; j < a.Columns; j++)
                {
                    result[i, j] = a[i, j] - b[i, j];
                }
            }
            return result;
        }

        public static bool operator ==(Matrix a, Matrix b)
        {
            return Comparer.Instance.Equals(a, b);
        }

        public static bool operator !=(Matrix a, Matrix b)
        {
            return !Comparer.Instance.Equals(a, b);
        }

        public static bool operator <(Matrix a, Matrix b)
        {
            return a.Sum() < b.Sum();
        }

        public static bool operator >(Matrix a, Matrix b)
        {
            return a.Sum() > b.Sum();
        }

        private double Sum()
        {
            double sum = 0;
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    sum += data[i, j];
                }
            }
            return sum;
        }

        public class Comparer : IEqualityComparer<Matrix>
        {
            public static Comparer Instance { get; } = new Comparer();
            private Comparer() { }

            public bool Equals(Matrix x, Matrix y)
            {
                if (x == null || y == null)
                    return false;

                if (x.Rows != y.Rows || x.Columns != y.Columns)
                    return false;

                for (int i = 0; i < x.Rows; i++)
                {
                    for (int j = 0; j < x.Columns; j++)
                    {
                        if (x[i, j] != y[i, j])
                            return false;
                    }
                }
                return true;
            }

            public int GetHashCode(Matrix obj)
            {
                if (obj == null)
                    return 0;

                int hash = 17;
                for (int i = 0; i < obj.Rows; i++)
                {
                    for (int j = 0; j < obj.Columns; j++)
                    {
                        hash = hash * 23 + obj[i, j].GetHashCode();
                    }
                }
                return hash;
            }
        }
    }
}
