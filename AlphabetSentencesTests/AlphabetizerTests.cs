using System.Collections.Generic;
using AlphabetSentences;
using NUnit.Framework;

namespace AlphabetSentencesTests
{
    [TestFixture]
    public class AlphabetizerTests
    {
        [Test]
        public void AlphabatizesGivenStrings()
        {
            List<string> testSentences = new List<string> {"f", "d", "s", "a"};
            List<string> expectedSentences = new List<string> {"a", "d", "f", "s"};

            Alphabetizer alphabetizer = new Alphabetizer();
            List<string> alphabetizedSentances = alphabetizer.Alphabetize(testSentences);

            Assert.That(alphabetizedSentances, Is.EqualTo(expectedSentences));
        }
    }
}