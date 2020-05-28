using System.Collections.Generic;
using AlphabetSentences;
using NUnit.Framework;

namespace AlphabetSentencesTests
{
    [TestFixture]
    public class SentenceSplitterTests
    {
        [Test]
        public void FullyEnclosedQuoteSentencesAreCaptured()
        {
            SentenceSplitter splitter = new SentenceSplitter();
            string testString =
                "And the Universal AC answered. \"THERE IS AS YET INSUFFICIENT DATA FOR A MEANINGFUL ANSWER.\"";
            var splitSentences = splitter.Split(testString);

            var expectedSentences = new List<string>
            {
                "And the Universal AC answered.",
                "\"THERE IS AS YET INSUFFICIENT DATA FOR A MEANINGFUL ANSWER.\""
            };

            Assert.That(splitSentences, Is.EquivalentTo(expectedSentences));
        }

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
        public void SplitterCanSplitFullFile()
        {
            SentenceSplitter splitter = new SentenceSplitter();
            string testString =
                "VJ-23X was not really serious, but MQ-17J pulled out his AC-contact from his pocket and placed it on the table before him?\n\"I've half a mind to,\" he said! \"It's something the human race will have to face someday.";
            var splitSentences = splitter.Split(testString);

            var expectedSentences = new List<string>
            {
                "VJ-23X was not really serious, but MQ-17J pulled out his AC-contact from his pocket and placed it on the table before him?",
                "I've half a mind to,\" he said!", "It's something the human race will have to face someday."
            };

            Assert.That(splitSentences, Is.EquivalentTo(expectedSentences));
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