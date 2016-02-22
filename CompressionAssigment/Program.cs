using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO.Compression;
using System.IO;


namespace CompressionAssigment
{
    static class Program
    {
        static void Main(string[] args)
        {
            string zippath;
            string path;
            string compress;
            Console.WriteLine("Enter a path for the zip file's location or the location of files to zip: ");
            path = Console.ReadLine();
            Console.WriteLine("Now enter a path for the a location to extract to or location of the new zip file: ");
            zippath = Console.ReadLine();

            do
            {
                Console.WriteLine("Do you want to compress? (y or n): ");
                compress = Console.ReadLine();
            } while (compress != "y" && compress != "n");

            if(compress == "y")
            {
                ZipFile.CreateFromDirectory(path, zippath);
            }

            if (compress == "n")
            {
                
            }
        }
    }
}
