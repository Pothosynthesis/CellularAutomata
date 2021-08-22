using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace PFrameWork
{
    class Drawing
    {
        static public void draw(ConsoleColor color, int xparam, int yparam)
        {
            Console.BackgroundColor = color;
            Console.SetCursorPosition(xparam,yparam);
            Console.WriteLine(" ");
        }

        static public void RectagleDraw(ConsoleColor color, int xparam1, int yparam1, int xparam2, int yparam2)
        {
            for (int i = 0;yparam1 < yparam2; yparam1++)
            {
                for (int e = 0; xparam1 < xparam2; xparam1++)
                {
                    Console.BackgroundColor = color;
                    Console.SetCursorPosition(xparam1, yparam1);
                    Console.WriteLine(" ");
                }
            }
        
        }
    }
}
