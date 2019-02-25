using System;
using System.IO;
namespace Arquvios
{
  class Program
        {
            static void Main(string[] args)
            {
            string path = @"/users/lucasmancini/downloads/Strider";
            try
            {
                var Folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS: ");
                foreach(string f in Folders)
                {
                    Console.WriteLine(f);
                }

                var Files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES: ");
                foreach(string s in Files)
                {
                    Console.WriteLine(s);
                }

                Directory.CreateDirectory(@"/users/lucasmancini/downloads/Strider/Dragon Ball Ultimate Battle 22");
            }

            catch(IOException e)
            {
                Console.WriteLine("DEU ERRO AI CHARA");
                Console.WriteLine(e);
            }
        }
        }
        }

