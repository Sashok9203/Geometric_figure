using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometric_figure
{
    internal class Square : Shape ,IPrintable,IMovable
    {
        protected uint _widht;
        public uint Widht
        {
            get => _widht;
            set => _widht = value < 2 ? 2 : value;
        }
        public char PrintSymbol { get ; set ; }
        public ConsoleColor Color { get ; set ; }
        public uint X { get ; set; }
        public uint Y { get ; set ; }

        public Square(uint side, char printSymbol, ConsoleColor color, uint x, uint y) 
        {
            Widht = side;
            PrintSymbol = printSymbol;
            Color = color;
            X = x;
            Y = y;
        }
        public Square(uint side) : this(side,'*',ConsoleColor.White,0,0) { }

        public override float Area() => _widht * _widht;
        public override float Perimeter() => _widht * 4;

        public virtual void Print()
        {
            ConsoleColor def = Console.ForegroundColor;
            Console.ForegroundColor = Color;
            for (int i = 0; i < _widht; i++)
            {
                Console.SetCursorPosition((int)X, (int)Y + i);
                for (int k = 0; k < _widht; k++)
                    Console.Write(PrintSymbol + " ");
            }
            Console.ForegroundColor = def;
        }
    }
}
