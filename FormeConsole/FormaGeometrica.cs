using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormeConsole
{
    public class FormaGeometrica
    {
        public string Nome { get; set; }

        public virtual double Area()
        {
            return 0;
        } 

        public virtual string Disegna()
        {
            return $"Forma : {Nome} Area: {Area()} ";
        }
    }
}
