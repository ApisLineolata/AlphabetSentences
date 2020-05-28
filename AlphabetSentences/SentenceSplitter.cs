using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace AlphabetSentences
{
    public class SentenceSplitter
    {
        public List<string> Split(string sentenceToSplit)
        {
            Regex splittingRegex = new Regex("(\"[^.!?\\n]+?[.!?\\n]\\)*\")|([^\"\\s].*?[.!?\\n]\\)*)");
            var matchedSentences = splittingRegex.Matches(sentenceToSplit);

            var splitSentences = new List<string>();
            foreach (Match match in matchedSentences)
                if (!match.Value.Contains("\n"))
                    splitSentences.Add(match.Value);

            return splitSentences;
        }
    }
}