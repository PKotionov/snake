using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snakes
{
    class Walls
    {
        List<Figure> wallList;

        public Walls(int mapWidth, int mapHeight)
        {

            wallList = new List<Figure>();


            //рисуем рамку
            HorizontLine upline = new HorizontLine(0, mapWidth - 2, 0, '+');
            HorizontLine downLine = new HorizontLine(0, mapWidth - 2, mapHeight - 2, '+');
            VerticlLine leftLine = new VerticlLine(0, 0, mapHeight - 2, '+');
            VerticlLine rightline = new VerticlLine(mapWidth - 2, 0, mapHeight - 2, '+');

            wallList.Add(upline);
            wallList.Add(downLine);
            wallList.Add(leftLine);
            wallList.Add(rightline);
        }

        internal bool IsHit(Figure figure)
        {
            foreach (var wall in wallList)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
        }

        public void Drow()
        {
            foreach (var wall in wallList)
            {
                wall.Drow();
            }
        }
    }
}
