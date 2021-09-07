using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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

        public void LoadFromFile(string nomefile)
        {
            //Console.WriteLine(messaggio + $"Load from {Nome} base: {Base} altezza: {Altezza} ");

            try
            {
                using (StreamReader reader = File.OpenText(nomefile))
                {

                    Console.WriteLine($"Lettura del file {nomefile} in corso");
                    string Read_Nome = reader.ReadLine();
                    Console.WriteLine($"Nome: {Read_Nome}");
                    int.TryParse(reader.ReadLine(), out int Read_Base);
                    Console.WriteLine($"Base: {Base}");
                    int.TryParse(reader.ReadLine(), out int Read_Altezza);
                    Console.WriteLine($"Altezza: {Altezza}");
                    Console.WriteLine("\n Fine del file \n");

                    this.Nome = Read_Nome;
                    this.Base = Read_Base;
                    this.Altezza = Read_Altezza;
                }
            }
            catch (IOException ioe)
            {
                Console.WriteLine(ioe.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void SaveToFile(string nomefile)
        {
            //Console.WriteLine(messaggio + $"Save to {Nome} base: {Base} altezza: {Altezza} ");

            try
            {
                using (StreamWriter writer = File.CreateText(nomefile))
                {
                    writer.WriteLine($"{Nome}");
                    writer.WriteLine($"{Base}");
                    writer.WriteLine($"{Altezza}");
                }
            }
            catch (IOException ioe)
            {
                Console.WriteLine(ioe.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

}
