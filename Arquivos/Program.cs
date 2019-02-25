using System;
using Arquivos.Entities;
using System.IO;
namespace Arquvios
{
  class Program
        {
            static void Main(string[] args)
            {

            string SourceFilePath = @"/users/lucasmancini/downloads/Strider/Strider.csv";

            try
            {
                string[] lines = File.ReadAllLines(SourceFilePath);
                string SourceFolderPath = Path.GetDirectoryName(SourceFilePath);
                string TargetOut = @"/users/lucasmancini/downloads/Strider" + @"/out";
                string TargetFile = @"/users/lucasmancini/downloads/Strider" + @"/sumarry.csv";

                Directory.CreateDirectory(TargetOut);


                using(StreamWriter sw = File.AppendText(TargetFile))
                {
                    foreach(string line in lines)
                    {
                        string[] fields = line.Split(',');
                        string name = fields[0];
                        double price = double.Parse(fields[1]);
                        int quantity = int.Parse(fields[2]);

                        Product prod = new Product(name, price, quantity);

                        sw.WriteLine(prod.Name + "," + prod.Total());



                    }

                }

            }
            catch(IOException e)
            {
                Console.WriteLine("Error with the archive");
                Console.WriteLine(e.Message);
            }
        }
        }
}



