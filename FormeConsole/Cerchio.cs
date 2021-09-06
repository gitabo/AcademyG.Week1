using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormeConsole
{
    class Cerchio : FormaGeometrica, IFileSerializable
    {
        public int x { get; set; } 
        public int y { get; set; }
        public double Raggio { get; set; }

        public override double Area()
        {
            return Math.PI * Math.Pow(Raggio , 2);
        }

        public override string Disegna()
        {
            return base.Disegna() + $"Coordinate centro: {x},{y} Raggio: {Raggio} ";
        }

        public void LoadFromFile(string messaggio)
        {
            Console.WriteLine(messaggio + $"Load from {Nome} centro: {x},{y}");
        }

        public void SaveToFile(string messaggio)
        {
            Console.WriteLine(messaggio + $"Save to {Nome} centro: {x},{y}");
        }
    }
}
