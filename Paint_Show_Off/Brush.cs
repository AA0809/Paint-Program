using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace Paint_Program
{
    public static class Brush
    {
        private static Point brushPos = new Point(0, 0);
        private static ConsoleColor color = ConsoleColor.Black;
        private static bool penDown = false;
        public static void brushUpdate()
        {
            brushPrint();
            ConsoleKeyInfo key = Console.ReadKey();
            switch (key.Key)
            {
                case ConsoleKey.UpArrow:
                    if (brushPos.Y > 0)
                    {
                        brushWipe();
                        brushPos.Y -= 1;
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (brushPos.Y < (Canvas.canvas.GetLength(1) - 1))
                    {
                        brushWipe();
                        brushPos.Y += 1;
                    }
                    break;
                case ConsoleKey.LeftArrow:
                    if (brushPos.X > 0)
                    {
                        brushWipe();
                        brushPos.X -= 1;
                    }
                    break;
                case ConsoleKey.RightArrow:
                    if (brushPos.X < (Canvas.canvas.GetLength(0) - 1))
                    {
                        brushWipe();
                        brushPos.X += 1;
                    }
                    break;
                case ConsoleKey.Enter:
                    if (penDown)
                    {
                        penDown = false;
                    }
                    else
                    {
                        penDown = true;
                    }
                    break;
                case ConsoleKey.Escape:
                    Environment.Exit(0);
                    break;
                case ConsoleKey.Tab:
                    colourChange();
                    break;
                case ConsoleKey.Delete:
                    penDown = false;
                    Canvas.clear();
                    break;
                case ConsoleKey.Backspace:
                    if (color == ConsoleColor.White)
                    {
                        color = ConsoleColor.Black;
                    }
                    else
                    {
                        color = ConsoleColor.White;
                    }
                    break;
                default:
                    break;
            }
            brushPrint();
            if (penDown)
            {
                Canvas.canvas[brushPos.X, brushPos.Y] = color;
                
            }
            
        }
        private static void brushPrint()
        {
            Console.SetCursorPosition(brushPos.X * 2,brushPos.Y);
            Console.BackgroundColor = color;
            if (color == ConsoleColor.White)
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("[]");
            }
            else
            {
                Console.Write("  ");
            }
        }

        private static void brushWipe()
        {
            Console.SetCursorPosition(brushPos.X * 2, brushPos.Y);
            Console.BackgroundColor = Canvas.canvas[brushPos.X,brushPos.Y];
            Console.Write("  ");
        }

        private static void brushBlink()
        {
            brushWipe();
            Thread.Sleep(100);
            brushPrint();
            Thread.Sleep(100);
        }

        private static void colourChange()
        {
            if (Convert.ToInt32(color) < 15)
            {
                color ++;
            }
            else
            {
                color = 0;
            }
        }
    }

}
