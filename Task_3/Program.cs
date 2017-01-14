using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle Triagle1 = new Triangle("Triagle", 15);
            Square Square1 = new Square("Square", 10);

            Console.WriteLine("Figure 1");
            Console.WriteLine("Name: " + Triagle1.Name);
            Console.WriteLine("Radius: " + Triagle1.Radius);
            Console.WriteLine("");

            Console.WriteLine("Figure 2");
            Console.WriteLine("Name: " + Square1.Name);
            Console.WriteLine("Side: " + Square1.Side);

            Console.ReadLine();
        }

        class Figure
        {
            public string Name { get; set; }
            public Figure(string Name)
            {
                this.Name = Name;
            }
        }

        class Triangle: Figure
        {
            public int Radius { get; set; }
            public Triangle(string Name, int Radius)
                :base(Name)
            {
                this.Radius = Radius;
            }
        }

        class Square: Figure
        {
            public int Side { get; set; }
            public Square(string Name, int Side)
                :base(Name)
            {
                this.Side = Side;
            }
        }

    }
}
