using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SoccerStats
{
    class Program
    {
        static void Main(string[] args)
        {
            string currentDirctory = Directory.GetCurrentDirectory();
            DirectoryInfo directory = new DirectoryInfo(currentDirctory);
            var fileName = Path.Combine(directory.FullName, "Data.txt");
            var file = new FileInfo(fileName);
            if (file.Exists)
            {
                using (var reader = new StreamReader(file.FullName))
                {
                    Console.SetIn(reader);
                    Console.WriteLine(Console.ReadLine());
                }


            }



        }
    }
}
