using NUnit.Framework;

namespace MoodAnalyser
{
    public class UseCase1
    {
        [Test]
        public void MoodAnalysis_ToTest_InSadMood()
        {
            string actual = Moodanalyser.AnalyseMood("i am in sad mood");
            Assert.AreEqual("SAD", actual);
        }
        [Test]
        public void MoodAnalysis_ToTest_InHappyMood()
        {
            string actual = Moodanalyser.AnalyseMood("i am in happy mood");
            Assert.AreEqual("HAPPY", actual);
        }
        [Test]
        public void MoodAnalysis_ToTest_InAnyMood()
        {
            string actual = Moodanalyser.AnalyseMood("i am in any mood");
            Assert.AreEqual("HAPPY", actual);
        }
       /* [Test]
        public void MoodAnalyser_passedInConstructor()
        {
            Moodanalyser moodAnalyser = new Moodanalyser("i am in happy mood");
            string actual = moodAnalyser.AnalyseMoo();
            Assert.AreEqual("HAPPY", actual);
        }*/
    }
}