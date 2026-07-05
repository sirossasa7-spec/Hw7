namespace Hw_7
{
    internal class Task4
    {
        interface IShape
        {
            double CalculateArea();
            double CalculatePerimeter();
        }

        class Circle : IShape
        {
            public double Radius { get; set; }

            public Circle(double radius)
            {
                Radius = radius;
            }

            public double CalculateArea()
            {
                return Math.PI * Radius * Radius;
            }

            public double CalculatePerimeter()
            {
                return 2 * Math.PI * Radius;
            }
        }

        class Rectangle : IShape
        {
            public double Width { get; set; }
            public double Height { get; set; }

            public Rectangle(double width, double height)
            {
                Width = width;
                Height = height;
            }

            public double CalculateArea()
            {
                return Width * Height;
            }

            public double CalculatePerimeter()
            {
                return 2 * (Width + Height);
            }
        }

        class Triangle : IShape
        {
            public double A, B, C;

            public Triangle(double a, double b, double c)
            {
                A = a;
                B = b;
                C = c;
            }

            public double CalculatePerimeter()
            {
                return A + B + C;
            }

            public double CalculateArea()
            {
                double p = CalculatePerimeter() / 2;
                return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            }
        }

        class Program
        {
            static void Main()
            {
                IShape circle = new Circle(5);
                IShape rectangle = new Rectangle(4, 6);
                IShape triangle = new Triangle(3, 4, 5);

                Console.WriteLine("Коло");
                Console.WriteLine("Площа: " + circle.CalculateArea());
                Console.WriteLine("Периметр: " + circle.CalculatePerimeter());

                Console.WriteLine();

                Console.WriteLine("Прямокутник");
                Console.WriteLine("Площа: " + rectangle.CalculateArea());
                Console.WriteLine("Периметр: " + rectangle.CalculatePerimeter());

                Console.WriteLine();

                Console.WriteLine("Трикутник");
                Console.WriteLine("Площа: " + triangle.CalculateArea());
                Console.WriteLine("Периметр: " + triangle.CalculatePerimeter());
            }
        }
    }
}
