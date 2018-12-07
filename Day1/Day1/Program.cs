using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            var frequencies = ReadFile();

            var result = Frequenceitor.GetResultingFrequency(frequencies);

            Console.WriteLine($"Result is: {result}");
            Console.WriteLine("...");
            Console.ReadKey();
        }

        private static List<int> ReadFile()
        {
            var frequencies = new List<int>();
            var path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"../../../input.txt"); ;
            var lines = File.ReadLines(path);

            foreach (var line in lines)
            {
                var frequency = Int32.Parse(line);
                frequencies.Add(frequency);
            }

            return frequencies;
        }
    }
}
