namespace Geometric_figure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Line line = new Line(10);
            Square square = new Square(5);
            Rectangle rec =  new Rectangle(8, 5);
            line.Color = ConsoleColor.Red;
            line.X = 5;
            line.Y = 2;
            line.Print();

            square.Color = ConsoleColor.Blue;
            square.PrintSymbol = 'x';
            (square as IMovable)?.Move(5,5);
            square.Print();

            rec.Color = ConsoleColor.DarkGreen;
            rec.PrintSymbol = '0';
            (rec as IMovable)?.Move(15, 15);
            rec.Print();
        }
    }
}