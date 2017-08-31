using System;
using System.Collections.Generic;
using System.Linq;
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
            {"two", 2}
        };

        public static string Average(string input)
        {
            if (string.IsNullOrEmpty(input))
                return "n/a";

            var numberList = input.Split(' ');
            int sum = numberList.Select(x => numberDic[x]).Sum();
            return numberDic.FirstOrDefault(x=>x.Value == sum / numberList.Length).Key;
        }
    }
}
