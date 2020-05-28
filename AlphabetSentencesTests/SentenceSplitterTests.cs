using System.Collections.Generic;
using AlphabetSentences;
using NUnit.Framework;

namespace AlphabetSentencesTests
{
    [TestFixture]
    public class SentenceSplitterTests
    {
        [Test]
        public void QuotationMarksAreRemovedTest()
        {
            SentenceSplitter splitter = new SentenceSplitter();
            var testSentence = "This will be. \"Four sentences. Also a quote.\" Trailing too.";
            List<string> expectedSentences = new List<string>
                {"This will be.", "Four sentences.", "Also a quote.", "Trailing too."};
            List<string> sentences = splitter.Split(testSentence);
            Assert.That(sentences, Is.EquivalentTo(expectedSentences));
        }

        [Test]
        public void SplitterSplitsPeriodsTest()
        {
            SentenceSplitter splitter = new SentenceSplitter();
            var testSentence = "This will be. Two sentences.";
            List<string> expectedSentences = new List<string> {"This will be.", "Two sentences."};
            List<string> sentences = splitter.Split(testSentence);
            Assert.That(sentences, Is.EquivalentTo(expectedSentences));
        }
    }
}