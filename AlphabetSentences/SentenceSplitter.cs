using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace AlphabetSentences
{
    public class SentenceSplitter
    {
        public List<string> Split(string sentenceToSplit)
        {
            Regex splittingRegex = new Regex("([^\"\\s].*?[.!?\\n])");
            var matchedSentences = splittingRegex.Matches(sentenceToSplit);

            var splitSentences = new List<string>();
            foreach (Match match in matchedSentences) splitSentences.Add(match.Value);
            return splitSentences;
        }
    }
}