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
                if (type != null)
                {
                Object obj = Activator.CreateInstance(type);
                return obj;
                }
                else
                {
                    throw new MoodAnalysisException(MoodAnalysisException.MoodList.NoSuch_Class, "no such class present");
                }

            }
            catch (NullReferenceException)
            {
                throw new MoodAnalysisException(MoodAnalysisException.MoodList.NoSuch_Class, "no such class present");
            }
        }

    }
}
