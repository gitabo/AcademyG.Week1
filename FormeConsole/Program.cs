using System;

namespace FormeConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Cerchio cerchio = new Cerchio();
            Rettangolo rettangolo = new Rettangolo();
            Triangolo triangolo = new Triangolo();

            cerchio.Nome = "cerchio";
            cerchio.x = 0;
            cerchio.y = 0;
            cerchio.Raggio = 2;

            rettangolo.Nome = "rettangolo";
            rettangolo.Larghezza = 3;
            rettangolo.Altezza = 2;

            triangolo.Nome = "triangolo";
            triangolo.Base = 5;
            triangolo.Altezza = 2;

            Console.WriteLine(cerchio.Disegna());
            Console.WriteLine(rettangolo.Disegna());
            Console.WriteLine(triangolo.Disegna());

            IFileSerializable cerchio1 = new Cerchio { Nome = "cerchio1", x = 1, y = 1 };
            IFileSerializable rettangolo1 = new Rettangolo { Nome = "rettangolo1", Larghezza = 5, Altezza = 3 };
            IFileSerializable triangolo1 = new Triangolo { Nome = "triangolo1", Base = 3, Altezza = 6 };

            cerchio1.SaveToFile("Prova Cerchio ");
            cerchio1.LoadFromFile("Prova Cerchio ");
            rettangolo1.SaveToFile("Prova Rettangolo ");
            rettangolo1.LoadFromFile("Prova Rettangolo ");
            triangolo1.SaveToFile("Prova Triangolo ");
            triangolo1.LoadFromFile("Prova Triangolo ");
        }
    }
}