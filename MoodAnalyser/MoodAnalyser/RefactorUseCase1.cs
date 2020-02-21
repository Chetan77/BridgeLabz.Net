using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyser
{
    class RefactorUseCase1
    {
        [Test]
        public void GivenSadMessage_InConstructor_WhenAnalyse_ReturnSad()
        {
            Moodanalyser moodAnalyser = new Moodanalyser("i am in sad mood");
            string actual = moodAnalyser.AnalyseMoo();
            Assert.AreEqual("SAD", actual);
        }
        [Test]
        public void GivenHappyMessage_InConstructor_WhenAnalyse_ReturnHappy()
        {
            Moodanalyser moodAnalyser = new Moodanalyser("i am in happy mood");
            string actual = moodAnalyser.AnalyseMoo();
            Assert.AreEqual("HAPPY", actual);
        }
        [Test]
        public void GivenAnyMessage_InConstructor_WhenAnalyse_ReturnHAppy()
        {
            Moodanalyser moodAnalyser = new Moodanalyser("i am in any mood");
            string actual = moodAnalyser.AnalyseMoo();
            Assert.AreEqual("HAPPY", actual);
        }
    }
}
