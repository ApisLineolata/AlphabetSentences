using System;
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
            List<string> splitSentances = new List<string>();
            splitSentances.AddRange(splitter.Split(storyLines));

            Alphabetizer alphabetizer = new Alphabetizer();
            var alphabatizedSentences = alphabetizer.Alphabetize(splitSentances);

            File.WriteAllLines("../../AlphabetizedSentences.txt", alphabatizedSentences);
            Console.ReadLine();
        }
    }
}