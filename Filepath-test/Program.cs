using System;
using System.IO;
using System.Linq;

namespace FilesystemTesting
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var fNames = GetFileNames(@"C:\Users\ImranB\Documents\Test");
            foreach(var name in fNames)
            {
                Console.WriteLine(name);
            }

        }
        private static string[] GetFileNames(string path)
        {
            var files = Directory.EnumerateFiles(path); 
            string[] fileNames = files.ToArray();  
            return fileNames;  
        }
    }
}
