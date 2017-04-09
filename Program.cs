using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace snakes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);
            
            //рисуем рамку
            HorizontLine upline = new HorizontLine(0, 78, 0, '+');
            upline.Drow();
            HorizontLine downLine = new HorizontLine(0, 78, 24, '+');
            downLine.Drow();
            VerticlLine leftLine = new VerticlLine(0, 0, 24, '+');
            leftLine.Drow();
            VerticlLine rightline = new VerticlLine(78, 0, 24, '+');
            rightline.Drow();

            //отрисовки точек
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.Right);
            snake.Drow();

            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.Createfood();
            food.Drow();

            while (true)
            {
                if (snake.Eat(food))
                {
                    food = foodCreator.Createfood();
                    food.Drow();
                }
                else
                {
                    snake.Move();
                }
                    if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
                snake.Move();
                Thread.Sleep(500);
            }
                                          
          
        }
       
    }
}
