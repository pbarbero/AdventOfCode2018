using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode
{
    public static class Coordinator
    {
        public static int GetLargestArea(List<string> coordinates)
        {
            var mainCoordinates = ParseData(coordinates);
            var dictionary = BuildDictionary(mainCoordinates);
            var centrals = SelectCentralCoordinates(mainCoordinates);
            return dictionary.Where(x => centrals.Contains(x.Key)).Select(x => x.Value.Count()).Max();
        }

        public static string GetClosestCoordinate(Tuple<int, int> coordinate, List<Tuple<int, int, string>> mainCoordinates)
        {
            var distances = new List<Tuple<string, int>>();

            foreach (var mainCoordinate in mainCoordinates)
            {
                var distance = GetTaxicabDistance(mainCoordinate.Item1, coordinate.Item1, mainCoordinate.Item2, coordinate.Item2);

                distances.Add(new Tuple<string, int>(mainCoordinate.Item3, distance));
            }

            var minDistance = distances.Select(x => x.Item2).Min();

            var distanceCoordinates = distances.Where(x => x.Item2 == minDistance);

            if (distanceCoordinates.Count() == 1)
            {
                return distanceCoordinates.First().Item1;
            }
            else
            {
                return string.Empty;
            }
        }

        public static int GetTaxicabDistance(int x1, int x2, int y1, int y2)
        {
            return Math.Abs(x1 - x2) + Math.Abs(y1 - y2);
        }

        private static List<Tuple<int, int, string>> ParseData(List<string> lines)
        {
            var coordinates = new List<Tuple<int, int, string>>();
            var name = 1;

            foreach (var line in lines)
            {
                var splited = line.Split(',');
                var tuple = new Tuple<int, int, string>(
                    int.Parse(splited[0].Trim()),
                    int.Parse(splited[1].Trim()),
                    name.ToString()
                    );

                coordinates.Add(tuple);
                name++;
            }

            return coordinates;
        }

        private static Dictionary<string, List<Tuple<int, int>>> BuildDictionary(List<Tuple<int, int, string>> mainCoordinates)
        {
            var dictionary = new Dictionary<string, List<Tuple<int, int>>>();

            for (int j = 0; j < mainCoordinates.Select(x => x.Item2).Max(); j++)
            {
                for (int i = 0; i < mainCoordinates.Select(x => x.Item1).Max(); i++)
                {
                    var coordinate = new Tuple<int, int>(i, j);
                    var closestCoordinate = GetClosestCoordinate(coordinate, mainCoordinates);

                    if (!string.IsNullOrEmpty(closestCoordinate))
                    {
                        if (dictionary.ContainsKey(closestCoordinate))
                        {
                            dictionary[closestCoordinate].Add(coordinate);
                        }
                        else
                        {
                            dictionary.Add(closestCoordinate, new List<Tuple<int, int>>() { coordinate });
                        }
                    }
                }
            }

            return dictionary;
        }

        private static List<string> SelectCentralCoordinates(List<Tuple<int, int, string>> mainCoordinates)
        {
            var centrals = new List<string>();

            foreach (var coordinate in mainCoordinates)
            {
                var isCentral = mainCoordinates.Any(mainCoordinate => IsLessThan(coordinate, mainCoordinate))
                             && mainCoordinates.Any(mainCoordinate => IsBiggerThan(coordinate, mainCoordinate));

                if (isCentral)
                {
                    centrals.Add(coordinate.Item3);
                }
            }

            return centrals;
        }

        private static bool IsLessThan(Tuple<int, int, string> coordinate1, Tuple<int, int, string> mainCoordinate)
        {
            return coordinate1.Item1 < mainCoordinate.Item1 && coordinate1.Item2 < mainCoordinate.Item2;
        }

        private static bool IsBiggerThan(Tuple<int, int, string> coordinate1, Tuple<int, int, string> mainCoordinate)
        {
            return coordinate1.Item1 > mainCoordinate.Item1 && coordinate1.Item2 > mainCoordinate.Item2;
        }
    }
}
