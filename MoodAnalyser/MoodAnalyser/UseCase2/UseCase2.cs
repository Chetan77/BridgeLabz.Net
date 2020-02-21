using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyser.UseCase2
{
    class UseCase2
    {
        [Test]
        public void GivenMessageNull_WhenAnalyse_ReturnHappy()
        {
            string actual=MoodWithExceptionHandling.ReturningMoodByHandlingException(null);
            Assert.AreEqual("HAPPY", actual);
        }
    }
}
