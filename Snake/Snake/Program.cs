using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);

            HorizontalLines upline = new HorizontalLines(0, 78, 0, '+');
            HorizontalLines downline = new HorizontalLines(0, 78, 24, '+');
            VerticalLines leftLine = new VerticalLines(0, 24, 0, '+');
            VerticalLines rightLine = new VerticalLines(0, 24, 78, '+');
            upline.Draw();
            downline.Draw();
            leftLine.Draw();
            rightLine.Draw();


            





            Console.ReadKey();
        }
    }
}
