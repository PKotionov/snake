using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snakes
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');
   //         p1.Drow();

            Point p2 = new Point(4, 5, '#');
   //         p2.Drow();

            List<int> numList = new List<int>();
            numList.Add(0);
            numList.Add(1);
            numList.Add(2);

            int x = numList[ 0];
            int y = numList[1];
            int z = numList[2];

            foreach(int i in numList)
            {
                Console.WriteLine(i);
            }

            numList.RemoveAt(0);

            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);

            int xzopa = 10;
            int yzopa = 10;

            Point p3 = new Point(xzopa, yzopa, 'Ж');
            Point p4 = new Point(xzopa+1, yzopa, 'O');
            Point p5 = new Point(xzopa + 2, yzopa, 'П');
            Point p6 = new Point(xzopa + 3, yzopa, 'A');


            pList.Add(p3);
            pList.Add(p4);
            pList.Add(p5);
            pList.Add(p6);



            foreach (Point px in pList)
            {
           px.Drow();
            }
           
               

            
                                  
            Console.ReadLine();

        }
       
    }
}
