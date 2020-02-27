//-----------------------------------------------------------------------
// <copyright file="MoodAnalyserReflector.cs" company="BridgeLabz">
//     Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Chetan Choudhari"/>
//-----------------------------------------------------------------------

namespace MoodAnalyserLibrary
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Text;

    public class MoodAnalyserReflector
    {

        /// <summary>
        /// Creates the instance.
        /// </summary>
        /// <param name="className">Name of the class.</param>
        /// <param name="opt">The opt.</param>
        /// <returns></returns>
        /// <exception cref="MoodAnalyserLibrary.MoodAnalysisException">
        /// null message was passed
        /// or
        /// no such class present
        /// or
        /// no such class present
        /// or
        /// No such method exception
        /// </exception>
        public static Object CreateInstance(string className, params object[] opt)
        {
            try
            {
                Type type = Type.GetType("MoodAnalyserLibrary." + className);
                if (type != null)
                {
                    Object obj = Activator.CreateInstance(type, opt);
                    if (obj == null)
                    {
                        throw new MoodAnalysisException(MoodAnalysisException.MoodList.No_Mood, "null message was passed");
                    }
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

        /// <summary>
        /// Methods the information.
        /// </summary>
        /// <param name="className">Name of the class.</param>
        /// <param name="opt">The opt.</param>
        /// <returns></returns>
        /// <exception cref="MoodAnalyserLibrary.MoodAnalysisException">
        /// No such method present
        /// or
        /// No such method present
        /// </exception>
        public static string MethodInfo(string className, params object[] opt)
        {
            try
            {
                Type type = Type.GetType("MoodAnalyserLibrary." + className);
                if (type != null)
                {
                    Object obj = Activator.CreateInstance(type, opt[1]);
                    MethodInfo[] methods = type.GetMethods();
                    foreach (var method in methods)
                    {
                        if (method.Name == (string)opt[0])
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
            catch (MissingMethodException)
            {
                    throw new MoodAnalysisException(MoodAnalysisException.MoodList.No_Such_Method, "No such method present");
            }
            return null;
        }

        /// <summary>
        /// Reflectors the method information.
        /// </summary>
        /// <param name="className">Name of the class.</param>
        /// <param name="opt">The opt.</param>
        /// <returns></returns>
        /// <exception cref="MoodAnalyserLibrary.MoodAnalysisException">
        /// No such method present
        /// or
        /// No such cunstructor with parameter
        /// or
        /// null reference exception
        /// </exception>
        public static string ReflectorMethodInfo(string className, params object[] opt)
        {
            try
            {
                Type type = Type.GetType("MoodAnalyserLibrary." + className);
                if (type != null)
                {
                    Object obj = Activator.CreateInstance(type, opt);
                    MethodInfo[] methods = type.GetMethods();
                    foreach (var method in methods)
                    {
                        if (method.Name == (string)opt[0])
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
            catch (MissingMethodException)
            {
                    throw new MoodAnalysisException(MoodAnalysisException.MoodList.No_Such_Class_With_Parameter, "No such cunstructor with parameter");
            }
            catch (NullReferenceException)
            {
                throw new MoodAnalysisException(MoodAnalysisException.MoodList.No_Mood, "null reference exception");
            }
            return null;
        }
    }
}
