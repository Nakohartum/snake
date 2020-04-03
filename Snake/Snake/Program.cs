﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
       
        static void Main(string[] args)
        {

            HorizontalLines upline = new HorizontalLines(0, 78, 0, '+');
            HorizontalLines downline = new HorizontalLines(0, 78, 24, '+');
            VerticalLines leftLine = new VerticalLines(0, 24, 0, '+');
            VerticalLines rightLine = new VerticalLines(0, 24, 78, '+');
            upline.Draw();
            downline.Draw();
            leftLine.Draw();
            rightLine.Draw();

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Snake.Direction.Right);
            snake.Draw();
            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while (true)
            {
                if (snake.Eat(food))
                {
                    
                    food = foodCreator.CreateFood();

                    food.Draw();
                    snake.Draw();

                }
                else
                {
                    snake.Move();
                }
                Thread.Sleep(100);
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    snake.HandleKey(key.Key);
                }
                Thread.Sleep(100);
                
            }





            
        }
    }
}
