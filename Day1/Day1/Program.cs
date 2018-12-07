using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace AdventOfCode
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"Write day to execute..");
            var day = Console.ReadLine();

            var correctDay = true;

            while (correctDay)
            {
                switch (day)
                {
                    case "1":
                        correctDay = false;
                        Day1();
                        break;
                    case "2":
                        correctDay = false;
                        Day2();
                        break;
                    default:
                        Console.WriteLine($"Fuck u, insert me a correct day");
                        day = Console.ReadLine();
                        break;
                };
            }

            
        }

        private static void Day1()
        {
            var frequencies = new List<int>();
            var lines = ReadFile(@"../../../input1.txt");

            foreach (var line in lines)
            {
                var frequency = Int32.Parse(line);
                frequencies.Add(frequency);
            }

            var result = Frequenceitor.GetResultingFrequency(frequencies);

            Console.WriteLine($"Result is: {result}");
            Console.ReadKey();

            var resultTwice = Frequenceitor.GetFrequencyReachesTwice(frequencies);

            Console.WriteLine($"Result device reaches twice is: {resultTwice}");
            Console.ReadKey();
        }

        private static void Day2()
        {
            var boxes = new List<string>();
            var lines = ReadFile(@"../../../input2.txt");

            foreach (var line in lines)
            {
                boxes.Add(line.Trim());
            }

            var result = Checksumeitor.GetChecksum(boxes);

            Console.WriteLine($"Result is: {result}");
            Console.ReadKey();
        }

        private static IEnumerable<string> ReadFile(string filePath)
        {
            var frequencies = new List<int>();
            var path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), filePath);

            return File.ReadLines(path);
        }
    }
}
