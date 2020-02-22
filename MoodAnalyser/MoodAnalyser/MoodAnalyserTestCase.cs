using MoodAnalyserLibrary;
using NUnit.Framework;

namespace MoodAnalyserProject
{
    public class Tests
    {
        [Test]
        public void GivenSadMessage_WhenAnalyse_ReturnSad()
        {
            MoodAnalyser moodAnalyser = new MoodAnalyser("i am in sad mood");
            string actual = moodAnalyser.AnalyseMood();
            Assert.AreEqual("SAD", actual);
        }
        [Test]
        public void GivenHappyMessage_WhenAnalyse_ReturnHappy()
        {
            MoodAnalyser moodAnalyser = new MoodAnalyser("i am in happy mood");
            string actual = moodAnalyser.AnalyseMood();
            Assert.AreEqual("HAPPY", actual);
        }
        [Test]
        public void GivenAnyMessage_WhenAnalyse_ReturnAny()
        {
            MoodAnalyser moodAnalyser = new MoodAnalyser("i am in any mood");
            string actual = moodAnalyser.AnalyseMood();
            Assert.AreEqual("HAPPY", actual);
        }
    }
}