using System.Collections.Generic;
using System.Linq;

namespace AlphabetSentences
{
    public class Alphabetizer
    {
        public List<string> Alphabetize(List<string> stringsToAlphabetize)
        {
            var sortedStrings = stringsToAlphabetize.ToList();
            sortedStrings.Sort();
            return sortedStrings;
        }
    }
}