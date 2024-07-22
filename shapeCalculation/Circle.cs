using Calculation;
using System;

namespace Hesaplama
{
    public class Circle : Program
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * radius * radius;
        }

        public double calculateArea()
        {
            throw new NotImplementedException();
        }

        public double CalculatePerimeter()
        {
            return 2 * Math.PI * radius;
        }

        public double calculatePerimeter()
        {
            throw new NotImplementedException();
        }
    }
}
