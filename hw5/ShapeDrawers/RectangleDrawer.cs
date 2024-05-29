using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw5.ShapeDrawers
{
    public class RectangleDrawer
    {
        public void Draw(int width, int height)
        {
            for (int i = 0; i < height; i++)
            {
                Console.WriteLine(new string('*', width));
            }
        }
    }
}
