namespace WindowsFormsApplication1
{
    public class Triangle
    {
        public double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }
        public string Type { get; set; }

        public Triangle(double a, double b, double c)
        {
            if (a <= 0 && b <= 0 && c <= 0)
                throw new TriangleException("Все значения должны быть строго больше 0");
            if ((a > 10000000000000000000 && b > 10000000000000000000 && c > 10000000000000000000))
                throw new TriangleException("Все значения должны быть строго меньше 10000000000000000000");
            
            this.a = a;
            this.b = b;
            this.c = c;
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
            if (CheckExisting())
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
