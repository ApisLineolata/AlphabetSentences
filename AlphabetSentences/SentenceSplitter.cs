using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace AlphabetSentences
{
    public class SentenceSplitter
    {
        public List<string> Split(string sentenceToSplit)
        {
            // This regex has two parts to it. The first part,(\"[^.!?\\n]+?[.!?\\n]\\)*\") tries to find
            // sentences that are enclosed fully by quotes For example:    "Hello there!" would end 
            // as {"Hello there!"}
            // The second part, ([^\"\\s].*?[.!?\\n]\\)*), doesn't allow quotation marks in it for cases
            // where there are multiple sentences in one set of quotes. Like:    "What are you doing! Stop that!"
            // would exclude the enclosing quotation marks and end up with {What are you doing!, Stop that!}
            Regex splittingRegex = new Regex("(\"[^.!?\\n]+?[.!?\\n]\\)*\")|([^\"\\s].*?[.!?\\n]\\)*)");
            var matchedSentences = splittingRegex.Matches(sentenceToSplit);

            var splitSentences = new List<string>();

            // For some reason on C# it catches these newline sentences that don't happen for the
            // regex testers tried. This removes those inconsistencies.
            foreach (Match match in matchedSentences)
                if (!match.Value.Contains("\n"))
                    splitSentences.Add(match.Value);

            return splitSentences;
        }
    }
}