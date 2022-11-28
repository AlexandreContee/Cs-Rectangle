using System;
using System.Globalization;

namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Retangulo ret1 = new Retangulo();
            
            Console.WriteLine("Entre a largura e altura do retângulo: ");
            double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            ret1.Largura = largura;
            ret1.Altura = altura;

            Console.WriteLine("AREA = " + ret1.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERÍMETRO = " + ret1.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + ret1.Diagonal().ToString("F2", CultureInfo.InvariantCulture));        
        }
    }
}