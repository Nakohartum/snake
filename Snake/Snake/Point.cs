using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        public int x;
        public int y;
        public char sym;
        public Point()
        {

        }
        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }
        public void Move(int offset, Snake.Direction direction)
        {
            if(direction == Snake.Direction.Right)
            {
                x += offset;
            }
            else if(direction == Snake.Direction.Left)
            {
                x -= offset;
            }
            else if(direction == Snake.Direction.Up)
            {
                y += offset;
            }
            else if(direction == Snake.Direction.Down)
            {
                y -= offset;
            }
        }
        public Point(int x, int y,char sym)
        {
            this.x = x;
            this.y = y;
            this.sym = sym;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(sym);
        }
        public override string ToString()
        {
            return x + ", " + y + ", " + sym;
        }
    }
}
