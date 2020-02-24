using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace MoodAnalyserLibrary
{
    public class MoodAnalyserFactory
    {

        public static Object CreateInstance(string className)
        {
            try
            {
                Type type = Type.GetType("MoodAnalyserLibrary." + className);
                Object obj = Activator.CreateInstance(type);
                return obj;

                throw new MoodAnalysisException(MoodAnalysisException.MoodList.NoSuch_Class, "no such class present");
            }
            catch (Exception)
            {
                throw new MoodAnalysisException(MoodAnalysisException.MoodList.NoSuch_Class, "no such class present");
            }
        }

    }
}
