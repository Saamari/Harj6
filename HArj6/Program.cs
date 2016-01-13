using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HArj6
{
    class Program
    {
        static void Main(string[] args)
        {

            double matka;



            Console.WriteLine("anna ajetun matkan määrä");

            matka = double.Parse(Console.ReadLine());
            double bensa = matka / 100 * 7.02;
            double hinta = bensa * 1.595;

            Console.WriteLine("bensaa mennyt {0}", bensa);
            Console.WriteLine("hinta on {0:F}", hinta);
        }
    }
}
