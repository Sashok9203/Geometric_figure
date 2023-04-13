using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometric_figure
{
    internal class Line : Shape, IPrintable
    {
        private uint _lenght;

        public uint Lenght 
        {
            get => _lenght;
            set => _lenght = value < 1 ? 1 : value;
        }
     
        public char PrintSymbol { get; set; }
        public ConsoleColor Color { get; set; }
        public uint X { get; set; }
        public uint Y { get; set; }

        public Line(uint lenght, char printSymbol, ConsoleColor color, uint x, uint y)
        {
            Lenght = lenght;
            PrintSymbol = printSymbol;
            Color = color;
            X = x;
            Y = y;
        }
        public Line(uint length) : this(length, '*', ConsoleColor.White, 0, 0) { }
        public override float Area() => Lenght;
        public override float Perimeter() => Lenght;

        public void Print()
        {
            ConsoleColor def = Console.ForegroundColor;
            Console.ForegroundColor = Color;
            string tmp = new string(PrintSymbol, (int)Lenght);
            Console.SetCursorPosition((int)X, (int)Y);
            Console.Write(tmp);
            Console.ForegroundColor = def;
        }
    }
}
