using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventOfCode
{
    public static class Coordinator
    {
        private static List<Tuple<int, int>> MainCoordinates;

        public static int GetLargestArea(List<string> coordinates)
        {
            MainCoordinates = ParseData(coordinates);

            return 17;
        }

        private static string GetClosestCoordinate(Tuple<int, int> coordinate)
        {
            var minDistance = int.MaxValue;
            var closestCoordinate = string.Empty;

            foreach (var mainCoordinate in MainCoordinates)
            {
                var distance = GetTaxicabDistance(mainCoordinate.Item1, coordinate.Item1, mainCoordinate.Item2, coordinate.Item2);

                if (distance < minDistance)
                {
                    minDistance = distance;
                    closestCoordinate = ;
                }
            }

            return closestCoordinate;
        }
        
        public static int GetTaxicabDistance(int x1, int x2, int y1, int y2)
        {
            return Math.Abs(x1 - x2) + Math.Abs(y1 - y2);
        }

        private static List<Tuple<int, int>> ParseData(List<string> lines)
        {
            var coordinates = new List<Tuple<int, int>>();

            foreach (var line in lines)
            {
                var splited = line.Split(',');
                var tuple = new Tuple<int, int>(
                    Int32.Parse(splited[0].Trim()),
                    Int32.Parse(splited[1].Trim())
                    );

                coordinates.Add(tuple);
            }

            return coordinates;
        }
    }
}
