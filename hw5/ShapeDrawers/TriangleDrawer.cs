using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw5.ShapeDrawers
{
    public class TriangleDrawer
    {
        public void Draw(int height)
        {
            for (int i = 1; i <= height; i++)
            {
                Console.WriteLine(new string(' ', height - i) + new string('*', i * 2 - 1));
            }
        }
    }
}
