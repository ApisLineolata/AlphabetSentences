using System.Collections.Generic;
using System.Linq;

namespace AlphabetSentences
{
    public class SentenceSplitter
    {
        public List<string> Split(string sentenceToSplit)
        {
            var splitSentences = sentenceToSplit.Split('.');
            var splitList = splitSentences.ToList();
            splitList.Remove(splitList.Last());
            List<string> trimmedSentences = new List<string>();
            foreach (var splitItem in splitList)
            {
                string trimmedItem = splitItem;

                // Needs to trim twice to catch any whitespaces before the quotation marks
                // and then any remaining after the quotation mark is removed
                trimmedItem = trimmedItem.Trim();
                trimmedItem = trimmedItem.Trim('"');
                trimmedItem = trimmedItem.Trim();

                trimmedItem = trimmedItem + ".";
                trimmedSentences.Add(trimmedItem);
            }

            return trimmedSentences;
        }
    }
}