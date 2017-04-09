using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snakes
{
    class FoodCreator
    {
        int mapHeigh;
        int mapWeigh;
        char sym;

        Random random = new Random();

        public FoodCreator(int mapHeigh, int mapWeigh, char sym)
        {
            this.mapHeigh = mapHeigh;
            this.mapWeigh = mapWeigh;
            this.sym = sym;
        }

        public Point Createfood()
        {
            int x = random.Next(2, mapWeigh - 2);
            int y = random.Next(2, mapHeigh - 2);
            return new Point(x, y, sym);
        }


    }
}
