using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snakes
{
    class FoodCreator
    {
        int mapHeight;
        int mapWeight;
        char sym;

        Random random = new Random();

        public FoodCreator(int mapHeight, int mapWeight, char sym)
        {
            this.mapHeight = mapHeight;
            this.mapWeight = mapWeight;
            this.sym = sym;
        }

        public Point Createfood()
        {
            int x = random.Next(2, mapHeight - 2);
            int y = random.Next(2, mapWeight - 2);
            return new Point(x, y, sym);
        }


    }
}
