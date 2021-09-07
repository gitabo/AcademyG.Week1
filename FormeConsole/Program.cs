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

            IFileSerializable cerchio1 = new Cerchio { Nome = "cerchio1", x = 1, y = 1, Raggio = 3 };
            IFileSerializable rettangolo1 = new Rettangolo { Nome = "rettangolo1", Larghezza = 5, Altezza = 3 };
            IFileSerializable triangolo1 = new Triangolo { Nome = "triangolo1", Base = 3, Altezza = 6 };

            cerchio1.SaveToFile(@"C:\Users\User\source\repos\AcademyG.Week1\FormeConsole\cerchio1.txt");
            //cerchio1.LoadFromFile("Prova Cerchio ");
            rettangolo1.SaveToFile(@"C:\Users\User\source\repos\AcademyG.Week1\FormeConsole\rect1.txt");
            //rettangolo1.LoadFromFile("Prova Rettangolo ");
            triangolo1.SaveToFile(@"C:\Users\User\source\repos\AcademyG.Week1\FormeConsole\triangolo1.txt");
            //triangolo1.LoadFromFile("Prova Triangolo ");

            Cerchio cerchio3 = new Cerchio();
            Rettangolo rettangolo3 = new Rettangolo();
            Triangolo triangolo3 = new Triangolo();

            cerchio3.LoadFromFile(@"C:\Users\User\source\repos\AcademyG.Week1\FormeConsole\cerchio3.txt");
            rettangolo3.LoadFromFile(@"C:\Users\User\source\repos\AcademyG.Week1\FormeConsole\rect3.txt");
            triangolo3.LoadFromFile(@"C:\Users\User\source\repos\AcademyG.Week1\FormeConsole\triangolo3.txt");

            Console.WriteLine("Cerchio letto da file prima della modifica");
            Console.WriteLine($"{cerchio3.Nome} centro: {cerchio3.x},{cerchio3.y} raggio: {cerchio3.Raggio}");

            //Modifico cerchio3
            cerchio3.Nome = "cerchio3 modificato";

            //scrivo cerchio3 modificato sul file cerchio3_modificato.txt
            cerchio3.SaveToFile(@"C:\Users\User\source\repos\AcademyG.Week1\FormeConsole\cerchio3_modificato.txt");

        }
    }
}