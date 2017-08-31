using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace StringAverage
{
    public class StringAverage
    {
        private static Dictionary<string, int> numberDic = new Dictionary<string, int>()
        {
            {"zero", 0},
            {"one", 1},
            {"two", 2},
            {"three", 3},
            {"four", 4},
            {"five", 5},
            {"six", 6},
            {"seven", 7},
            {"eight", 8},
            {"nine", 9}
        };

        public static string Average(string input)
        {
            if (string.IsNullOrEmpty(input))
                return "n/a";

            var numberList = input.Split(' ');
            foreach (var number in numberList)
            {
                if (numberDic.Keys.Any(key => key.Contains(number)) == false)
                    return "n/a";
            }

            int avg = numberList.Select(x => numberDic[x]).Sum() / numberList.Length;
            return numberDic.FirstOrDefault(x => x.Value == avg).Key;
        }
    }
}
