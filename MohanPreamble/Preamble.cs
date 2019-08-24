using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MohanPreamble
{
    public class Preamble
    {
        public List<string> showWords(string preambleText)
        {
            string result = Regex.Replace(preambleText, @"\p{P}", "");

            List<string> preambleSplit = result.Split(" ").ToList();

            return preambleSplit;
        }

        public int showTWords(string preambleText)
        {
            var preambleSplit = showWords(preambleText);
            var tWords = new List<string>();

            foreach (string word in preambleSplit)
            {
                if (word.StartsWith('t'))
                {
;                    tWords.Add(word);
                };
            }
            return tWords.Count();
        }

        public int showEWords(string preambleText)
        {
            var preambleSplit = showWords(preambleText);
            var eWords = new List<string>();

            foreach (string word in preambleSplit)
            {
                if (word.StartsWith('e'))
                {
                    eWords.Add(word);
                };
            }
            return eWords.Count();
        }

        public int showTEWords(string preambleText)
        {
            var preambleSplit = showWords(preambleText);
            var tEWords = new List<string>();

            foreach (string word in preambleSplit)
            {
                if (word.StartsWith('t') && word.EndsWith('e'))
                {
                    tEWords.Add(word);
                };
            }
            return tEWords.Count();
        }
    }
}
