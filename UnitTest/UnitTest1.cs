using NUnit.Framework;
using MoodAnalyzer;

namespace UnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        // TC 3.1 Given NULL Mood
        [Test]
        [TestCase("I am in Sad Mood")]
        public void Test1_AnalyzeMood_PassingValidInput_ReturnTrue(string input)
        {
            MoodAnalyser msg1 = new MoodAnalyser(input);
            string expected = "Sad";

            var actual = msg1.AnalyseMood1();

            Assert.AreEqual(expected, actual);
        }

        // TC 3.2 Given Empty Mood
        [Test]
        [TestCase("I am in Any Mood")]
        public void Test2_AnalyzeMood_PassingValidInput_ReturnTrue(string input)
        {
            MoodAnalyser msg2 = new MoodAnalyser(input);
            string expected = "Happy";

            var actual = msg2.AnalyseMood2();

            Assert.AreEqual(expected, actual);
        }
    }
}