namespace Task1
{

    ///
    /// Напишите на C# или Python библиотеку для поставки внешним клиентам,
    /// которая умеет вычислять площадь круга по радиусу и треугольника 
    /// по трем сторонам. Дополнительно к работоспособности оценим:
    
    ///Юнит-тесты
    ///Легкость добавления других фигур
    ///Вычисление площади фигуры без знания типа фигуры в compile-time
    ///Проверку на то, является ли треугольник прямоугольным
    /// 

    interface I_Square
    {
        double Square();
        bool Exist();
    }
    
    public class Circle:I_Square
    {
        public double Radius { get; set; }
        public Circle(double radius)
        {
            Radius = radius;
            if (!Exist()) throw new ArgumentOutOfRangeException("Circle does not exist");
        }
        public double Square()
        {
            return Math.PI * Math.Pow(Radius,2);
        }

        public bool Exist()
        {
            if (Radius <= 0) return false;
            else return true;
        }
    }

    public class Triangle :I_Square
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public bool Is_Rectangular { get; set; }

        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
            if (!Exist()) throw new ArgumentOutOfRangeException("Triangle does not exit");
            if (Rectanglular()) Is_Rectangular = true;
        }

        public double Square()
        {
            double P = (A+B+C)/2;
            return Math.Sqrt(P*(P-A)*(P-B)*(P-C));
        }

        public bool Exist()
        {
            if (A < B + C & B < A + C & C < B + A) return true;
            else return false;
        }

        private bool Rectanglular()
        {
            bool a1 = Math.Pow(C, 2) == Math.Pow(B, 2) + Math.Pow(A, 2);
            bool a2 = Math.Pow(B, 2) == Math.Pow(A, 2) + Math.Pow(C, 2);
            bool a3 = Math.Pow(A, 2) == Math.Pow(B, 2) + Math.Pow(C, 2);
            if (a1 || a2 || a3) return true;
            return false;
        }

    }
    
    public class Figure
    {
        I_Square figure;
        public double square { get; set; }
        public Figure(double radius) 
        {
            figure = new Circle(radius);
        }

        public Figure(double a, double b, double c)
        {
            figure = new Triangle(a, b, c);
        }

        public double Square()
        {
            return figure.Square();
        }
    }
}
