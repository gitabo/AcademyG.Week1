using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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

        public void LoadFromFile(string nomefile)
        {
            //Console.WriteLine(messaggio + $"Load from {Nome} centro: {x},{y}");
            //Lettura da file
            try
            {
                using (StreamReader reader = File.OpenText(nomefile))
                {

                    Console.WriteLine($"Lettura del file {nomefile} in corso");
                    string Read_Nome = reader.ReadLine();
                    Console.WriteLine($"Nome: {Nome}");
                    int.TryParse(reader.ReadLine(), out int Read_x);
                    Console.WriteLine($"x: {Read_x}");
                    int.TryParse(reader.ReadLine(), out int Read_y);
                    Console.WriteLine($"y: {Read_y}");
                    double.TryParse(reader.ReadLine(), out double Read_Raggio);
                    Console.WriteLine($"Raggio: {Read_Raggio}");
                    Console.WriteLine("\n Fine del file \n");

                    this.Nome = Read_Nome;
                    this.x = Read_x;
                    this.y = Read_y;
                    this.Raggio = Read_Raggio;
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
            //Console.WriteLine(messaggio + $"Save to {Nome} centro: {x},{y}");

            try
            {
                using (StreamWriter writer = File.CreateText(nomefile))
                {
                    writer.WriteLine($"{Nome}");
                    writer.WriteLine($"{x}");
                    writer.WriteLine($"{y}");
                    writer.WriteLine($"{Raggio}");
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
