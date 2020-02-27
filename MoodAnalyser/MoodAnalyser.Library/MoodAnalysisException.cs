//-----------------------------------------------------------------------
// <copyright file="MoodAnalysisException.cs" company="BridgeLabz">
//     Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Chetan Choudhari"/>
//-----------------------------------------------------------------------


namespace MoodAnalyserLibrary
{

    using System;

    public class MoodAnalysisException :Exception
    {
        public enum MoodList
        {
            Empty_Mood,No_Mood,NoSuch_Class,No_Such_Method,No_Such_Class_With_Parameter
        }
        public string message;
        public MoodList moodList;

        /// <summary>
        /// Initializes a new instance of the <see cref="MoodAnalysisException"/> class.
        /// </summary>
        /// <param name="_moodList">The mood list.</param>
        /// <param name="_message">The message.</param>
        public MoodAnalysisException(MoodList _moodList,string _message)
        
        {
            this.moodList = _moodList;
            this.message = _message;
        }
        /// <summary>
        /// Gets a message that describes the current exception.
        /// </summary>
        public override string Message
        {
            get
            {
                return message;
            }
        }
    }
}
