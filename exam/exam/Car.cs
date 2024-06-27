using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    internal class Car
    {
        private string _color { get; set; }
        private float _fuelAmount { get; set; }
        private float _fuelCapacity { get; set; }
        private Dictionary<float, float> _fuelConsumptionTable;
        private string _fuelConsumptionType;

        public Car(string color, float fuelAmount, 
            float fuelCapacity, Dictionary<float, float> fuelConsumptionTable,
            string fuelConsumptionType)
        {
            _color = color;
            _fuelAmount = fuelAmount;
            _fuelCapacity = fuelCapacity;
            _fuelConsumptionTable = fuelConsumptionTable;
            _fuelConsumptionType = fuelConsumptionType;
        }

        public Dictionary<float, float> getFuelConsumptionTable() { return _fuelConsumptionTable; }
        public string getFuelConsumptionType() { return _fuelConsumptionType; }
    }
}
