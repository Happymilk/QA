using System;

namespace WindowsFormsApplication1
{
    public class Triangle
    {
        public double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }
        public string Type { get; set; }
        public bool Exist { set; get; }

        public Triangle(params dynamic[] values)
        {
            double first, second, third;
            bool f, s, t;

            if (values.Length != 3)
                throw new TriangleException("Значений должно быть 3");

            f = Double.TryParse(values[0], out first);
            s = Double.TryParse(values[1], out second);
            t = Double.TryParse(values[2], out third);

            if (!f || !s || !t)
                throw new TriangleException("Неверный ввод (символьные значения)");
            if (first <= 0 || second <= 0 || third <= 0)
                throw new TriangleException("Все значения должны быть строго больше 0");
            if ((first > 1000000000 || second > 1000000000 || third > 1000000000))
                throw new TriangleException("Все значения должны быть строго меньше 1000000000");

            this.a = first;
            this.b = second;
            this.c = third;
            this.Exist = CheckExisting();
            this.Type = GetTypeOfTriangle();
        }

        public Triangle(double value1, double value2, double value3)
        {
            double first, second, third;
            
            first = value1;
            second = value2;
            third = value3;
            
            if (first <= 0 || second <= 0 || third <= 0)
                throw new TriangleException("Все значения должны быть строго больше 0");
            if ((first > Double.MaxValue || second > Double.MaxValue || third > Double.MaxValue))
                throw new TriangleException("Все значения должны быть строго меньше 1000000000");

            this.a = first;
            this.b = second;
            this.c = third;
            this.Exist = CheckExisting();
            this.Type = GetTypeOfTriangle();
        }

        public bool CheckExisting()
        {
            if (a < b + c && b < a + c && c < a + b)
                return true;
            return false;
        }

        public string GetTypeOfTriangle()
        {
            if (Exist)
                if (a == b && a == c && b == c)
                    return "Треугольник равносторонний";
                else if (a == b || a == c || b == c)
                    return "Треугольник равнобедренный";
                else
                    return "Треугольник неравносторонний";
            else
                throw new TriangleException("Треугольник не существует");
        }
    }
}
