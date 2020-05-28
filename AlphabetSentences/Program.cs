using System;
using System.Collections.Generic;
using System.IO;

namespace AlphabetSentences
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var storyLines = File.ReadAllLines("../../ShortStory.txt");

            SentenceSplitter splitter = new SentenceSplitter();
            List<string> splitSentances = new List<string>();
            foreach (var storyLine in storyLines) splitSentances.AddRange(splitter.Split(storyLine));

            Alphabetizer alphabetizer = new Alphabetizer();
            var alphabatizedSentences = alphabetizer.Alphabetize(splitSentances);

            Console.ReadLine();
        }
    }
}