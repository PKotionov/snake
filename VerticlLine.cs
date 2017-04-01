using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snakes
{
    class VerticlLine
    {
        List<Point> vList = new List<Point>();

        public VerticlLine(int x, int yUp, int ydown, char sym)
        {
            for (int y = yUp; y <= ydown; y++)
            {
                Point p = new Point(x, y, sym);
                vList.Add(p);
            }

        }

        public void Drow()
        {
            foreach (Point p in vList)
            {
                p.Drow();
            }
        }

    }
}
