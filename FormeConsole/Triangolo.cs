using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormeConsole
{
    class Triangolo : FormaGeometrica, IFileSerializable
    {
        public double Base { get; set; }
        public double Altezza { get; set; }

        public override double Area()
        {
            return (Base*Altezza)/2;
        }

        public override string Disegna()
        {
            return base.Disegna() + $"Base: {Base} Altezza: {Altezza} ";
        }

        public void LoadFromFile(string messaggio)
        {
            Console.WriteLine(messaggio + $"Load from {Nome} base: {Base} altezza: {Altezza} ");
        }

        public void SaveToFile(string messaggio)
        {
            Console.WriteLine(messaggio + $"Save to {Nome} base: {Base} altezza: {Altezza} ");
        }
    }

}
