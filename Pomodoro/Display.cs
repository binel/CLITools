using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Pomodoro
{
    public class Display
    {
        public int Width { get; set; }

        public int Height { get; set; }

        public char[,] Buffer { get; init; }

        public Display() 
        {
            Width = 100;
            Height = 10;
            Buffer = new char[Height, Width];

            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++)
                {
                    Buffer[y, x] = ' ';
                }
            }
        }

        public void Draw()
        {
            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++)
                {
                    char c = Buffer[y, x];
                    if (c != ' ')
                    {
                        Console.SetCursorPosition(x, y);
                        Console.Write(c);
                    }
                }
            }
        }

        public void Clear()
        {
            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++)
                {
                    char c = Buffer[y, x];
                    if (c != ' ')
                    {
                        Console.SetCursorPosition(x, y);
                        Console.Write(' ');
                        Buffer[y, x] = ' ';
                    }
                }
            }
        }

        public void SetChar(int x, int y, char c)
        {
            Buffer[y, x] = c;
        }
    }
}
