using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Better_Random
{
    public static class RandomExtensions
    {
        public static double NextDouble(this Random random, double maximum) => random.NextDouble() * maximum;

        public static string NextString(this Random random, params string[] options) => options[random.Next(options.Length)];

        public static bool CoinFlip(this Random random, double probabilityOfHeads = 0.5) => random.NextDouble() < probabilityOfHeads;
    }
}
