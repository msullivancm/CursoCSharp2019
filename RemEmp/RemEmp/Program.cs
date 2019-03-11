using System;
using System.IO;

namespace RemEmp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o caminho dos arquivos a serem renomeados: ");
            string sourceDirectory = Console.ReadLine();
            Console.Write("Entre com a cadeia de caracter a ser alterada: ");
            string origin = Console.ReadLine();
            Console.Write("Entre com a cadeia de caracter substituta: ");
            string destiny = Console.ReadLine();

            try
            {
                var txtFiles = Directory.EnumerateFiles(sourceDirectory, $"*{origin}*");

                foreach (string currentFile in txtFiles)
                {
                    string fileNameOld = currentFile.ToString();
                    string fileNameNew = fileNameOld.Replace(origin,destiny);
                    
                    File.Copy(fileNameOld, fileNameNew);
                    Console.WriteLine($"Arquivo {fileNameOld} copiado para {fileNameNew}");

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }



        }
    }
}
