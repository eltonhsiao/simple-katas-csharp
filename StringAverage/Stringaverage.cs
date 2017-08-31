using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAverage
{
    public class StringAverage
    {
        public static string Average(string input)
        {
            if (string.IsNullOrEmpty(input))
                return "n/a";

            var numberDic = new Dictionary<string, int>()
            {
                {"one", 1},
                {"two", 2}
            };

            var numberList = input.Split(' ');
            int sum = 0;
            foreach (var number in numberList)
            {
                sum += numberDic[number];
            }

            return numberDic.FirstOrDefault(x=>x.Value == sum / numberList.Length).Key;
        }
    }
}
