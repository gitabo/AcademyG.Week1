using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormeConsole
{
    class Rettangolo : FormaGeometrica, IFileSerializable
    {
        public double Larghezza { get; set; }
        public double Altezza { get; set; }

        public override double Area()
        {
            return Larghezza * Altezza;
        }

        public override string Disegna()
        {
            return base.Disegna() + $"Larghezza: {Larghezza} Altezza: {Altezza} ";
        }

        public void LoadFromFile(string messaggio)
        {
            Console.WriteLine(messaggio + $"Load from {Nome} base: {Larghezza} altezza: {Altezza} ");
        }

        public void SaveToFile(string messaggio)
        {
            Console.WriteLine(messaggio + $"Save to {Nome} base: {Larghezza} altezza: {Altezza} ");
        }
    }
}
