using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    internal class Cargo
    {
        private string _name { get; set; }
        private float _weight { get; set; }

        public Cargo(string name, float weight)
        {
            _name = name;
            _weight = weight;
        }
    }
}
