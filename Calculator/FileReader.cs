using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CalculatorWithPriority
{
    public class FileReader : IRead
    {
        public string Expression { get; set; }
        string path = @"..\expression.txt";
        public FileReader() {}
        public string Read()
        {
            Console.WriteLine($"Current directory is '{Environment.CurrentDirectory}'");
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("2 + 2");
                }
            }
            string s;
            using (StreamReader sr = File.OpenText(path))
            {
                while ((s = sr.ReadLine()) != null)
                {
                    return s;
                }
                
            }
            return s;
        }
    }
}
