using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hesaplama
{
    public class ShapeTest
    {
        public static void Main(string[] args)
        {
            
            Circle daire = new Circle(3.0);
            Console.WriteLine($"Daire alanı: {daire.CalculateArea()}");
            Console.WriteLine($"Daire çevresi: {daire.CalculatePerimeter()}");

            Rectangle dikdörtgen = new Rectangle(4.0,5.0);
            Console.WriteLine($"Dikdörtgen alanı: {dikdörtgen.CalculateArea()}");
            Console.WriteLine($"Dikdörtgen çevresi: {dikdörtgen.CalculatePerimeter()}");

            Console.ReadLine();
        }
    }
}
