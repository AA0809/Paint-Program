using System.Drawing;

namespace Paint_Program
{
    internal class Program
    {
        static Size canvasSize = new Size(40, 40);
        static void Main(string[] args)
          
        {
            Canvas.canvasInit(ConsoleColor.White, canvasSize);
            Canvas.render();
            textPrint((canvasSize.Width + 5) * 2);
            while (true)
            {
                
                Brush.brushUpdate();
            }
        }

        static void textPrint(int line)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(line, 5);
            Console.Write("█ ▄▄  ██   ▄█    ▄     ▄▄▄▄▀");
            Console.SetCursorPosition(line, 6);
            Console.Write("█   █ █ █  ██     █ ▀▀▀ █   ");
            Console.SetCursorPosition(line, 7);
            Console.Write("█▀▀▀  █▄▄█ ██ ██   █    █   ");
            Console.SetCursorPosition(line, 8);
            Console.Write("█     █  █ ▐█ █ █  █   █    ");
            Console.SetCursorPosition(line, 9);
            Console.Write(" █       █  ▐ █  █ █  ▀     ");
            Console.SetCursorPosition(line, 10);
            Console.Write("  ▀     █     █   ██        ");
            Console.SetCursorPosition(line, 11);
            Console.Write("       ▀                    by Aviral Agarwal");

            Console.SetCursorPosition(line, 14);
            Console.Write("Controls:");
            Console.SetCursorPosition(line, 16);
            Console.Write("Arrow Keys       <- Move the brush");
            Console.SetCursorPosition(line, 17);
            Console.Write("Enter Key        <- Start and stop drawing");
            Console.SetCursorPosition(line, 18);
            Console.Write("Tab Key          <- Change the brush colour");
            Console.SetCursorPosition(line, 19);
            Console.Write("Backspace Key    <- Change the colour to White");
            Console.SetCursorPosition(line, 20);
            Console.Write("Delete Key       <- Clear the canvas");
            Console.SetCursorPosition(line, 25);
            Console.Write("TOP TIP!");
            Console.SetCursorPosition(line, 26);
            Console.Write("To delete parts of the drawing, change the");
            Console.SetCursorPosition(line, 27);
            Console.Write("brush colour to white and draw over it");
        }
    }
}