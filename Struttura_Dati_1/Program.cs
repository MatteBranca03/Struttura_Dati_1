using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;

namespace Struttura_Dati_1
{
    class Program
    {
        private const string FILE_NAME = @"Prova.txt";
        private const string FILE_NAME1 = @"Prova1.txt";
        static void Main(string[] args)
        {
            List<double> list = new List<double>();
            using (StreamReader rfile = new StreamReader(FILE_NAME))
            {
                string line;
                while((line = rfile.ReadLine()) != null)
                {
                    double n = double.Parse(line);
                    list.Add(n);
                }
            }
            using (StreamWriter sw = new StreamWriter(FILE_NAME1))
            {
                for (int i = list.Count - 1; i >= 0; i--)
                {
                    sw.WriteLine(list[i]);
                }
            }            
        }
    }
}
