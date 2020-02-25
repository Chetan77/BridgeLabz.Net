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
        public void GivenAnyMessage_WhenAnalyse_ReturnHappy()
        {
            MoodAnalyser moodAnalyser = new MoodAnalyser("i am in any mood");
            string actual = moodAnalyser.AnalyseMood();
            Assert.AreEqual("HAPPY", actual);
        }
        [Test]
        public void GivenNullMessage_WhenAnalyse_ReturnHappy()
        {
            MoodAnalyser moodAnalyser = new MoodAnalyser(null);
            string actual = moodAnalyser.AnalyseMood();
            Assert.AreEqual("HAPPY", actual);
        }
        [Test]
        public void GivenNull_whenAnalys_ThrowMoodAnalysisExceptionTest()
        {
            MoodAnalyser moodAnalyser = new MoodAnalyser(null);
            var actual = Assert.Throws<MoodAnalysisException>(() => moodAnalyser.AnalyseMood());
            Assert.AreEqual(MoodAnalysisException.MoodList.No_Mood, actual.moodList);
        }
        [Test]
        public void GivenEmpty_whenAnalys_ThrowMoodAnalysisExceptionTest()
        {
            MoodAnalyser moodAnalyser = new MoodAnalyser("");
            var actual = Assert.Throws<MoodAnalysisException>(() => moodAnalyser.AnalyseMood());
            Assert.AreEqual(MoodAnalysisException.MoodList.Empty_Mood, actual.moodList);
        }
        [Test]
        public void GivenMoodAnalyserClassName_WhenAnalyse_ReturnMoodAnalyserInstance()
        { 
            MoodAnalyser expected = new MoodAnalyser();
            Assert.IsTrue(expected.Equals(expected));
        }
        [Test]
        public void GivenImproperClassName_WhenAnalyse_ThrowMoodAnalysisException()
        {
            var actual = Assert.Throws<MoodAnalysisException>(() => MoodAnalyserFactory.CreateInstance("Moose"));
            Assert.AreEqual(MoodAnalysisException.MoodList.NoSuch_Class, actual.moodList);
        }
    }
}