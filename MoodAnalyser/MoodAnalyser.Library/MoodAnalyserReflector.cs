using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace MoodAnalyserLibrary
{
    public class MoodAnalyserReflector
    {

        public static Object CreateInstance(string className, params object[] opt)
        {
            try
            {
                Type type = Type.GetType("MoodAnalyserLibrary." + className);
                if (type != null)
                {
                    Object obj = Activator.CreateInstance(type, opt);
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
            catch (MissingMethodException)
            {
                throw new MoodAnalysisException(MoodAnalysisException.MoodList.No_Such_Method, "No such method exception");
            }
        }
        public static string MethodInfo(string className, params object[] opt)
        {
            try
            {
                Type type = Type.GetType("MoodAnalyserLibrary." + className);
                if (type != null)
                {
                    Object obj = Activator.CreateInstance(type,opt[0]);
                    MethodInfo[] methods = type.GetMethods();
                    foreach (var method in methods)
                    {
                        if (method.Name == (string)opt[1])
                        {
                            return ((MoodAnalyser)obj).AnalyseMood();
                        }
                        else
                        {
                            throw new MoodAnalysisException(MoodAnalysisException.MoodList.No_Such_Method, "No such method present");
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw new MoodAnalysisException(MoodAnalysisException.MoodList.No_Such_Method, "NO SUCH METHOD");
            }
            return null;
        }
    }
}
