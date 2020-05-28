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
            splitList = splitList.ConvertAll(sentence => sentence.Trim() + '.');

            return splitList;
        }
    }
}