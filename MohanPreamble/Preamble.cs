using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MohanPreamble
{
    public class Preamble
    {
        // Preamble String Function //
        public List<string> showWords(string preambleText)
        {
            string result = Regex.Replace(preambleText, @"\p{P}", "");

            // Splitting the Preamble //
            List<string> preambleSplit = result.Split(" ").ToList();

            return preambleSplit;
        }

        // Showing Number Of T Words Function //
        public int showTWords(string preambleText)
        {
            // Splitting the Preamble //
            var preambleSplit = showWords(preambleText);
            
            // Preamble T Words String For Each Function //
            var tWords = new List<string>();

            foreach (string word in preambleSplit)
            {
                if (word.StartsWith('t'))
                {
                    // Adding Number of T Words //
;                    tWords.Add(word);
                };
            }
            // Returning the Count Of T Words //
            return tWords.Count();
        }

        // Showing Number of E Words Function //
        public int showEWords(string preambleText)
        {
            // Splitting The Preamble //
            var preambleSplit = showWords(preambleText);

            // Preamble E Words String For Each Function //
            var eWords = new List<string>();

            foreach (string word in preambleSplit)
            {
                if (word.StartsWith('e'))
                {
                    // Adding Number of E Words //
                    eWords.Add(word);
                };
            }
            // Returning Number of E Words //
            return eWords.Count();
        }

        // Showing Number Of T/E Words Function //
        public int showTEWords(string preambleText)
        {
            // Splitting the Preamble //
            var preambleSplit = showWords(preambleText);

            // Preamble T/E Words For Each Function //
            var tEWords = new List<string>();

            foreach (string word in preambleSplit)
            {
                if (word.StartsWith('t') && word.EndsWith('e'))
                {
                    // Adding Number of T/E Words //
                    tEWords.Add(word);
                };
            }
            // Returning Number of T/E Words //
            return tEWords.Count();
        }
    }
}
