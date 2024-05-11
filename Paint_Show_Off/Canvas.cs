using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Paint_Program
{
    public static class Canvas
    {
        public static ConsoleColor[,] canvas;
        public static void canvasInit(ConsoleColor colour, Size size)
        {
            canvas = new ConsoleColor[size.Width, size.Height];
            for (int i = 0; i < size.Width; i++)
            {
                for (int j = 0; j < size.Height; j++)
                {
                    canvas[i, j] = colour;
                }
            }
        }
        
        public static void render()
        {
            for (int i = 0; i < canvas.GetLength(0); i++)
            {
                Console.SetCursorPosition(0, i);
                for (int j = 0; j < canvas.GetLength(1); j++)
                {
                    Console.BackgroundColor = canvas[i,j];
                    Console.Write("  ");
                }
            }
        }

        public static void clear()  
        {
            for (int i = 0; i < canvas.GetLength(0); i++)
            {
                Console.SetCursorPosition(0, i);
                for (int j = 0; j < canvas.GetLength(1); j++)
                {
                    canvas[i, j] = ConsoleColor.White;
                    
                }
            }
            Canvas.render();
        }

    }
}
