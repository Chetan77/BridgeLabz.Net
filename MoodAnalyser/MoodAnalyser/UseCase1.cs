using NUnit.Framework;

namespace MoodAnalyser
{
    public class UseCase1
    {
        [Test]
        public void GivenSadMessage_WhenAnalyse_ReturnSad()
        {
            string actual = Moodanalyser.AnalyseMood("i am in sad mood");
            Assert.AreEqual("SAD", actual);
        }
        [Test]
        public void GivenHappyMessage_WhenAnalyse_ReturnHappy()
        {
            string actual = Moodanalyser.AnalyseMood("i am in happy mood");
            Assert.AreEqual("HAPPY", actual);
        }
        [Test]
        public void GivenAnyMessage_WhenAnalyse_ReturnAny()
        {
            string actual = Moodanalyser.AnalyseMood("i am in any mood");
            Assert.AreEqual("HAPPY", actual);
        }
       
    }
}