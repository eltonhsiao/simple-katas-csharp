using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount
{
    public class WordCount
    {
        public static string CountWord(string input)
        {
            if (string.IsNullOrEmpty(input))
                return "";

            string output = String.Empty;
            var wordArray = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList().GroupBy(x => x);
            foreach (var i in wordArray)
            {
                output += i.Key + ": " + i.Count() + " ";
            }

            return output;
        }
    }
}
