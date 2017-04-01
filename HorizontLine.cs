﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snakes
{
    class HorizontLine
    {
        List<Point> pList;

        public HorizontLine(int xLeft, int xRight, int y, char sym)
        {
            pList = new List<snakes.Point>();
            for (int x = xLeft; x <= xRight; x++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);

            }
        }

        public void Drow()
        {
            foreach(Point p in pList) {
                p.Drow();
            }
        }

    }
}
