using System.Collections.Generic;
using System.IO;

namespace AlphabetSentences
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var storyLines = File.ReadAllText("../../ShortStory.txt");

            SentenceSplitter splitter = new SentenceSplitter();
            List<string> splitSentences = new List<string>();
            splitSentences.AddRange(splitter.Split(storyLines));

            Alphabetizer alphabetizer = new Alphabetizer();
            var alphabetizedSentences = alphabetizer.Alphabetize(splitSentences);

            File.WriteAllLines("../../AlphabetizedSentences.txt", alphabetizedSentences);
        }
    }
}