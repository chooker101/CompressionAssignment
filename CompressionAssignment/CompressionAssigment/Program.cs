using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO.Compression;
using System.IO;
using System.Windows.Forms;


namespace CompressionAssigment
{
    
    static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            string gui;
            do
            {
                Console.WriteLine("Do you want to use the GUI?(y or n):");
                gui = Console.ReadLine();
            } while (gui != "y" && gui != "n");

            if (gui == "y")
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new CarstensZipper());
            }
            else
			{
                string zippath;
                string path;
                string compress;
                Console.WriteLine("Enter a path for the zip file's location or the location of files to zip: ");
                path = Console.ReadLine();
                Console.WriteLine("{0}", path);
                Console.WriteLine("Now enter a path for the a location to extract to or location of the new zip file: ");
                zippath = Console.ReadLine();

                do
                {
                    Console.WriteLine("Do you want to compress? (y or n): ");
                    compress = Console.ReadLine();
                } while (compress != "y" && compress != "n");

                if (compress == "y")
                {
                    ZipFile.CreateFromDirectory(path, zippath);
                }

                if (compress == "n")
                {
                    ZipFile.ExtractToDirectory(path, zippath);
                }
            }
        }
    }
}
