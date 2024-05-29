using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw5.ShapeDrawers
{
    public class SquareDrawer
    {
        public void Draw(int sideLength)
        {
            for (int i = 0; i < sideLength; i++)
            {
                Console.WriteLine(new string('*', sideLength));
            }
        }
    }
}
