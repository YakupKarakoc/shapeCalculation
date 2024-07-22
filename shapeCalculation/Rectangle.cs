using Calculation;
using System;

namespace Hesaplama
{
    public class Rectangle : Program
    {
        private double x;
        private double y;

        public Rectangle(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double CalculateArea()
        {
            return x * y;
        }

        public double calculateArea()
        {
            throw new NotImplementedException();
        }

        public double CalculatePerimeter()
        {
            return 2 * (x + y);
        }

        public double calculatePerimeter()
        {
            throw new NotImplementedException();
        }
    }
}
