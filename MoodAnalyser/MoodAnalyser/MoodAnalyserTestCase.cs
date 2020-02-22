using MoodAnalyserLibrary;
using NUnit.Framework;

namespace MoodAnalyserProject
{
    public class Tests
    {
        [Test]
        public void GivenSadMessage_WhenAnalyse_ReturnSad()
        {
            string actual = MoodAnalyser.AnalyseMood("i am in sad mood");
            Assert.AreEqual("SAD", actual);
        }
        [Test]
        public void GivenHappyMessage_WhenAnalyse_ReturnHappy()
        {
            string actual = MoodAnalyser.AnalyseMood("i am in happy mood");
            Assert.AreEqual("HAPPY", actual);
        }
        [Test]
        public void GivenAnyMessage_WhenAnalyse_ReturnAny()
        {
            string actual = MoodAnalyser.AnalyseMood("i am in any mood");
            Assert.AreEqual("HAPPY", actual);
        }
    }
}