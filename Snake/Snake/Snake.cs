 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Snake
{
    class Snake : Figure
    {
        public enum Direction
        {
            Left, Right, Up, Down
        }
         Direction direction;
        public Snake(Point tail, int length, Direction direction)
        {
            this.direction = direction;
            pList = new List<Point>();
            for(int i = 0; i < length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, this.direction);
                pList.Add(p);
            }
        }

        public void Move()
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = GetNextPoint();
            pList.Add(head);

            tail.Clear();
            head.Draw();
        }
        public Point GetNextPoint()
        {
            Point head = pList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, this.direction);
            return nextPoint;
        }
        public void HandleKey(ConsoleKey key)
        {
            
            if (key == ConsoleKey.LeftArrow)
                this.direction = Snake.Direction.Left;
            else if (key == ConsoleKey.RightArrow)
                this.direction = Snake.Direction.Right;
            else if (key == ConsoleKey.DownArrow)
                this.direction = Snake.Direction.Down;
            else if (key == ConsoleKey.UpArrow)
                this.direction = Snake.Direction.Up;
        }
        public bool Eat(Point food)
        {
            Point head = GetNextPoint();
            if (head.IsHit(food))
            {
                food.sym = head.sym;
                pList.Add(food);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
