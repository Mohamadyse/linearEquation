using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    using System;
    public static class Kata
    {
        //"1 2 0 4 7\r\n0 2 0 2 8\r\n0 0 -1 4 6\r\n1 2 3 2 3"
        public static string Solve(string input)
        {
            int[,] factors = new int[3, 4];
            MakeFactors(input, factors);
            calculateDeterminant(factors);
            string result = "d";
            return result;
        }

        private static int calculateDeterminant(int[,] f)
        {
            return f[0, 0]*f[1, 1]*f[1, 2] + f[0, 1]*f[1, 2]*f[2, 0]+ f[0, 2]*f[1, 0]*f[2, 1] - f[0, 2]*f[1, 1]*f[2, 0] - f[0, 1]*f[1, 0]*f[2, 2] - f[0, 0]*f[1, 2]*f[2, 1];
        }

        private static void MakeFactors(string input, int[,] factors)
        {
            var lines = input.Split("\r\n");
            string[] numbers = new string[3]; ;
            var i = 0;
            foreach (var line in lines)
            {
                var j = 0;
                numbers = line.Split(" ");
                foreach (var number in numbers)
                {

                    factors[i, j] = int.Parse(number);
                    j++;
                }
                i++;
            }
        }
    }
}