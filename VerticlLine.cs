﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snakes
{
    class VerticlLine : Figure
    {
       
        public VerticlLine(int x, int yUp, int ydown, char sym)
        {
            pList = new List<Point>();
            for (int y = yUp; y <= ydown; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }
         
    }
}
