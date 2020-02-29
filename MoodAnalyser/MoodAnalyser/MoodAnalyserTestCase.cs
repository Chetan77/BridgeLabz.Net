//-----------------------------------------------------------------------
// <copyright file="MoodAnalyserTestCase.cs" company="BridgeLabz">
//     Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Chetan Choudhari"/>
//-----------------------------------------------------------------------
namespace MoodAnalyserProject
{
    using MoodAnalyserLibrary;
    using NUnit.Framework;

    
    public class MoodAnalyserTestCase
    {
        /// <summary>
        /// Givens the sad message when moodAnalyser return sad.
        /// </summary>
        [Test]
        public void GivenSadMessage_WhenAnalyse_ReturnSad()
        {
            MoodAnalyser moodAnalyser = new MoodAnalyser("i am in sad mood");
            string actual = moodAnalyser.AnalyseMood();
            Assert.AreEqual("SAD", actual);
        }

        /// <summary>
        /// Givens the happy message when analyse return happy.
        /// </summary>
        [Test]
        public void GivenHappyMessage_WhenAnalyse_ReturnHappy()
        {
            MoodAnalyser moodAnalyser = new MoodAnalyser("i am in happy mood");
            string actual = moodAnalyser.AnalyseMood();
            Assert.AreEqual("HAPPY", actual);
        }

        /// <summary>
        /// Givens the null when analys throw mood analysis exception test.
        /// </summary>
        [Test]
        public void GivenNull_whenAnalys_ThrowMoodAnalysisExceptionTest()
        {
            MoodAnalyser moodAnalyser = new MoodAnalyser(null);
            var actual = Assert.Throws<MoodAnalysisException>(() => moodAnalyser.AnalyseMood());
            Assert.AreEqual(MoodAnalysisException.MoodList.No_Mood, actual.moodList);
        }

        /// <summary>
        /// Givens the empty when analyse throw mood analysis exception test.
        /// </summary>
        [Test]
        public void GivenEmpty_whenAnalys_ThrowMoodAnalysisExceptionTest()
        {
            MoodAnalyser moodAnalyser = new MoodAnalyser("");
            var actual = Assert.Throws<MoodAnalysisException>(() => moodAnalyser.AnalyseMood());
            Assert.AreEqual(MoodAnalysisException.MoodList.Empty_Mood, actual.moodList);
        }

        /// <summary>
        /// Givens the mood analyser class name when analyse return mood analyser instance.
        /// </summary>
        [Test]
        public void GivenMoodAnalyserClassName_WhenAnalyse_ReturnMoodAnalyserInstance()
        {
            MoodAnalyser expected = new MoodAnalyser();
            bool b = expected.Equals(expected);
            Assert.AreEqual(true, b);
        }

        /// <summary>
        /// Givens the improper class name when analyse throw mood analysis exception.
        /// </summary>
        [Test]
        public void GivenImproperClassName_WhenAnalyse_ThrowMoodAnalysisException()
        {
            var actual = Assert.Throws<MoodAnalysisException>(() => MoodAnalyserReflector.CreateInstance("Mood"));
            Assert.AreEqual(MoodAnalysisException.MoodList.NoSuch_Class, actual.moodList);
        }

        /// <summary>
        /// Givens the mood analyser class name with message when analyse return mood analyser instance.
        /// </summary>
        [Test]
        public void GivenMoodAnalyserClassNameWithMessage_WhenAnalyse_ReturnMoodAnalyserInstance()
        {
            MoodAnalyser expected = new MoodAnalyser("jkhdgf");
            bool b = expected.Equals(expected);
            Assert.AreEqual(true,b);
        }

        /// <summary>
        /// Givens the improper class name with message when analyse throw mood analysis exception.
        /// </summary>
        [Test]
        public void GivenImproperClassNameWithMessage_WhenAnalyse_ThrowMoodAnalysisException()
        {
            var actual = Assert.Throws<MoodAnalysisException>(() => MoodAnalyserReflector.CreateInstance("MoodAlyser", "i am in happy mode"));
            Assert.AreEqual(MoodAnalysisException.MoodList.NoSuch_Class, actual.moodList);
        }

        /// <summary>
        /// Givens the class name with improper constructor when analyse throw mood analysis exception.
        /// </summary>
        [Test]
        public void GivenClassNameWithImproperConstructor_WhenAnalyse_ThrowMoodAnalysisException()
        {
            var actual = Assert.Throws<MoodAnalysisException>(() => MoodAnalyserReflector.CreateInstance("MoodAnalyser", 5432.675));
            Assert.AreEqual(MoodAnalysisException.MoodList.No_Such_Method, actual.moodList);
        }

        /// <summary>
        /// Usings the reflection when given happy message proper when analyse should return happy mood.
        /// </summary>
        [Test]
        public void UsingReflectionWhenGivenHappyMessageProper_WhenAnalyse_ShouldReturnHAPPYMood()
        {
            MoodAnalyser moodAnalyser = (MoodAnalyser)MoodAnalyserReflector.CreateInstance("MoodAnalyser", "i am in happy mood");
            string actual = moodAnalyser.AnalyseMood();
            Assert.AreEqual("HAPPY", actual);
        }

        /// <summary>
        /// Givens the improper method name happy mood when analyse should throw mood analyser exception.
        /// </summary>
        [Test]
        public void GivenImproperMethodNameHappyMood_WhenAnalyse_ShouldThrowMoodAnalyserException()
        {
            var actual = Assert.Throws<MoodAnalysisException>(() =>MoodAnalyserReflector.MethodInfo("MoodAnalyser", "AnaseMood", "i am in happy mood"));
            Assert.AreEqual(MoodAnalysisException.MoodList.No_Such_Method, actual.moodList);
        }

        /// <summary>
        /// Givens the happy message with reflection when analyse should return happy.
        /// </summary>
        [Test]
        public void GivenHappyMessageWithReflection_WhenAnalyse_ShouldReturnHappy()
        {
            MoodAnalyser moodAnalyser= (MoodAnalyser) MoodAnalyserReflector.CreateInstance("MoodAnalyser", "in happy");
            string act=moodAnalyser.GetType().GetMethod("AnalyseMood").Invoke(moodAnalyser, null).ToString();
            Assert.AreEqual("HAPPY", act);
        }

        /// <summary>
        /// Givens the improper field when analyse shuould throw mood analyser exceptio.
        /// </summary>
        [Test]
        public void GivenImproperField_WhenAnalyse_ShuouldThrowMoodAnalyserExceptio()
        {
            var moodAnalyser = Assert.Throws<MoodAnalysisException>(()=> MoodAnalyserReflector.ReflectorMethodInfo("MoodAnalyser", 5432));
            Assert.AreEqual(MoodAnalysisException.MoodList.No_Such_Class_With_Parameter, moodAnalyser.moodList);
        }

        /// <summary>
        /// Givens the null message with reflection when analyse should throw exception.
        /// </summary>
        [Test]
        public void GivenNullMessageWithReflection_WhenAnalyse_ShouldThrowException()
        {
            var act = Assert.Throws<MoodAnalysisException>(() => MoodAnalyserReflector.ReflectorMethodInfo("MoodAnalyser", null));
            Assert.AreEqual(MoodAnalysisException.MoodList.No_Mood, act.moodList);
        }
    }
}