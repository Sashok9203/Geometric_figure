using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometric_figure
{
    internal class Rectangle : Square
    {
        private uint _height;
        public uint Height
        {
            get => _height;
            set { _height = value < 2 ? 2 : value; }
        }
        public Rectangle(uint widht, uint height) : this(widht, height,'*', ConsoleColor.White, 0,0)  { }
        public Rectangle(uint widht, uint height, char printSymbol, ConsoleColor color, uint x, uint y) : base(widht,  printSymbol,  color,  x,  y)
        {
            Height = height;
            PrintSymbol = printSymbol;
            Color = color;
            X = x;
            Y = y;
        }

        public override float Area() => _widht * _height;
        public override float Perimeter() => (_widht + _height) * 2;

        public override void Print()
        {
            ConsoleColor def = Console.ForegroundColor;
            Console.ForegroundColor = Color;
            for (int i = 0; i < _height; i++)
            {
                Console.SetCursorPosition((int)X, (int)Y + i);
                for (int k = 0; k < _widht; k++)
                    Console.Write(PrintSymbol + " ");
            }
            Console.ForegroundColor = def;
        }
    }
}
