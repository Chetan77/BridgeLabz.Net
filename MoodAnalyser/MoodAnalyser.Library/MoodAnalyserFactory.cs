using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace MoodAnalyserLibrary
{
    public class MoodAnalyserFactory
    {

        public static Object CreateInstance(string className, params string[] opt)
        {
            try
            {
                Type type = Type.GetType("MoodAnalyserLibrary." + className);
                if (type != null)
                {
                Object obj = Activator.CreateInstance(type,opt);
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

       /* public static Type ObjectType(string className)
        {
            Type type = Type.GetType("MoodAnalyserLibrary." + className);
            return type;
        }
        public static Object CreateInstance1(Type type, string message)
        {
            try
            {
                if (type != null)
                {
                    //object obArr =  message ;
                    Object obj = Activator.CreateInstance(type, message);
                    return obj;
                }
                else
                {
                    throw new MoodAnalysisException(MoodAnalysisException.MoodList.No_Such_Class_With_Parameter, "no such class with parameter present");
                }
            }
            catch (NullReferenceException)
            {
                throw new MoodAnalysisException(MoodAnalysisException.MoodList.No_Such_Class_With_Parameter, "no such class with parameter present");
            }
        }*/
    }
}
