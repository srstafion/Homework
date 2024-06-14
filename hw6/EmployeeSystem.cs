namespace EmployeeSystem
{
    public class Employee
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }

        public Employee(string name, decimal salary)
        {
            Name = name;
            Salary = salary;
        }

        public static Employee operator +(Employee employee, decimal increase)
        {
            if (increase < 0)
                throw new ArgumentException("Increase amount cannot be negative");
            return new Employee(employee.Name, employee.Salary + increase);
        }

        public static Employee operator -(Employee employee, decimal decrease)
        {
            if (decrease < 0)
                throw new ArgumentException("Decrease amount cannot be negative");
            return new Employee(employee.Name, employee.Salary - decrease);
        }

        public static bool operator ==(Employee emp1, Employee emp2)
        {
            if (ReferenceEquals(emp1, null) && ReferenceEquals(emp2, null))
                return true;
            if (ReferenceEquals(emp1, null) || ReferenceEquals(emp2, null))
                return false;
            return emp1.Salary == emp2.Salary;
        }

        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return !(emp1 == emp2);
        }

        public static bool operator <(Employee emp1, Employee emp2)
        {
            return emp1.Salary < emp2.Salary;
        }

        public static bool operator >(Employee emp1, Employee emp2)
        {
            return emp1.Salary > emp2.Salary;
        }

        public class Comparer : IEqualityComparer<Employee>
        {
            public static Comparer Instance { get; } = new Comparer();

            private Comparer() { }

            public bool Equals(Employee x, Employee y)
            {
                if (x == null || y == null)
                    return false;

                return x.Name == y.Name && x.Salary == y.Salary;
            }

            public int GetHashCode(Employee obj)
            {
                if (obj == null)
                    return 0;

                return HashCode.Combine(obj.Name, obj.Salary);
            }
        }
    }
}
