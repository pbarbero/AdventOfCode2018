namespace AdventOfCode
{
    public static class Polarizeitor
    {
        public static int Scan(string polymer)
        {
            var continueProcess = true;

            while (continueProcess)
            {
                var indexToRemove = RecursiveScan(polymer);
                continueProcess = indexToRemove != -1;

                if (continueProcess)
                {
                    polymer = polymer.Remove(indexToRemove, 2);
                }

            }

            return polymer.Length;
        }

        public static bool Polarize(char unit0, char unit1)
        {
            return unit0.ToString().ToUpper() == unit1.ToString().ToUpper();
        }

        private static int RecursiveScan(string polymer)
        {
            for (int i = 0; i < polymer.Length - 1; i++)
            {
                var toBePolarized = Polarize(polymer[i], polymer[i + 1]);

                if (toBePolarized)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
