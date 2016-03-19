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

        public Triangle(params double[] values)
        {
            if (values.Length != 3)
                throw new TriangleException("Значений должно быть 3");
            if (values[0] <= 0 || values[1] <= 0 || values[2] <= 0)
                throw new TriangleException("Все значения должны быть строго больше 0");
            if ((values[0] > Double.MaxValue || values[1] > Double.MaxValue || values[2] > Double.MaxValue))
                throw new TriangleException("Все значения должны быть строго меньше 10000000000000000000");

            this.a = values[0];
            this.b = values[1];
            this.c = values[2];
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
