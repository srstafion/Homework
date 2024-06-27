using System.Drawing;

namespace exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter task number: ");
            int taskNumber = int.Parse(Console.ReadLine());
            switch(taskNumber)
            {
                case 1: SolveTask1(); break;
                default: Console.WriteLine("Invalid task"); break;
            }
        }
        static void SolveTask1()
        {
            var cars = ExtractCarFromFile("cars.txt");    
        }
        static List<Car> ExtractCarFromFile(string path)
        {
            var cars = new List<Car>();

            foreach (var line in File.ReadAllLines(path))
            {
                var dataParts = line.Split(';');
                var color = dataParts[0];
                var fuelAmount = float.Parse(dataParts[1]);
                var fuelCapacity = float.Parse(dataParts[2]);

                var fuelConsumptionTable = new Dictionary<float, float>();
                var consumptionDataParts = dataParts[3].Split(',');
                foreach (var value in consumptionDataParts)
                {
                    var consumptionValue = value.Split(',');
                    var speed = float.Parse(consumptionValue[0]);
                    var consumption = float.Parse(consumptionValue[1]);
                    fuelConsumptionTable[speed] = consumption;
                }

                var fuelConsumptionType = dataParts[4];

                cars.Add(new Car(color, fuelAmount, fuelCapacity,
                    fuelConsumptionTable, fuelConsumptionType));
            }
            return cars;
        }
        static List<Cargo> ExtractCargoFromFile(string path)
        {
            var cargo = new List<Cargo>();

            foreach (var line in File.ReadAllLines(path))
            {
                var dataParts = line.Split(';');
                var name = dataParts[0];
                var weight = float.Parse(dataParts[1]);
                cargo.Add(new Cargo(name, weight));
            }
            return cargo;
        }
        private static float calculateFuelConsumption(Car car, float weight, float distance)
        {
            var speed = car.getFuelConsumptionTable().Keys.Max();
            var consumption = car.getFuelConsumptionTable()[speed];
            
            if(car.getFuelConsumptionType() == "легковой")
            {
                consumption += 0.1 * weight;
            }
            else if(car.getFuelConsumptionType() == "грузовой")
            {
                consumption += 0.5 * weight;
            }
            return distance * consumption;
        }
        private st
    }
}
