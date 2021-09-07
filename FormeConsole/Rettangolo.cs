using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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

        public void LoadFromFile(string nomefile)
        {
            //Console.WriteLine(messaggio + $"Load from {Nome} base: {Larghezza} altezza: {Altezza} ");

         
            try
                {
                    using (StreamReader reader = File.OpenText(nomefile))
                    {

                        Console.WriteLine($"Lettura del file {nomefile} in corso");
                        string Read_Nome = reader.ReadLine();
                        Console.WriteLine($"Nome: {Read_Nome}");
                        int.TryParse(reader.ReadLine(), out int Read_Larghezza);
                        Console.WriteLine($"Larghezza: {Larghezza}");
                        int.TryParse(reader.ReadLine(), out int Read_Altezza);
                        Console.WriteLine("\n Fine del file \n");

                        this.Nome = Read_Nome;
                        this.Larghezza = Read_Larghezza;
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
            //Console.WriteLine(messaggio + $"Save to {Nome} base: {Larghezza} altezza: {Altezza} ");

            try
            {
                using (StreamWriter writer = File.CreateText(nomefile))
                {
                    writer.WriteLine($"{Nome}");
                    writer.WriteLine($"{Larghezza}");
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
