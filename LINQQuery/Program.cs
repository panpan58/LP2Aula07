using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace LINQQuery
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("roger1.txt");

            int linesin30 = lines.Count(line => line.Length < 31);
            double average = lines.Average(lines => lines.Length);
            int linein120 = lines.Count(line => line.Length > 120);
            IEnumerable<string> thewhys =
                from line in lines 
                where line.Contains('Y')
                select line.Trim().Split()[0].ToUpper();


            Console.WriteLine(linesin30);
            Console.WriteLine(average);
            Console.WriteLine(linein120);
            foreach(string y in thewhys)
                Console.WriteLine(y.ToString());
            
        }
    }
}
