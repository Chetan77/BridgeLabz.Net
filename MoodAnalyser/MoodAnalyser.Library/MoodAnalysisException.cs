using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserLibrary
{
    public class MoodAnalysisException :Exception
    {
        public enum MoodList
        {
            Empty_Mood,No_Mood
        }
        public string message;
        public MoodList moodList;

        public MoodAnalysisException(MoodList _moodList,string _message)
        {
            this.moodList = _moodList;
            this.message = _message;
        }
        public override string Message
        {
            get
            {
                return message;
            }
        }
    }
}
