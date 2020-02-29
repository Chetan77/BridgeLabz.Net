//-----------------------------------------------------------------------
// <copyright file="MoodAnalyser.cs" company="BridgeLabz">
//     Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Chetan Choudhari"/>
//-----------------------------------------------------------------------

namespace MoodAnalyserLibrary
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class MoodAnalyser
    {
        string msg;

        /// <summary>
        /// Initializes a new instance of the <see cref="MoodAnalyser"/> class.
        /// </summary>
        public MoodAnalyser()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MoodAnalyser"/> class.
        /// </summary>
        /// <param name="msg">The MSG.</param>
        public MoodAnalyser(string msg)
        {
            this.msg = msg;
        }

        /// <summary>
        /// Analyses the mood.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="MoodAnalyserLibrary.MoodAnalysisException">
        /// given mood is empty, please provide some mood
        /// or
        /// no method found, enter proper method
        /// or
        /// no mood, enter proper me
        /// </exception>
        public string AnalyseMood()
        {
            try
            {
                if (msg.ToLower().Contains("sad"))
                {
                    Console.WriteLine("returning SAD");
                    return "SAD";
                }
                else if (msg.ToLower().Contains("happy"))
                {
                    Console.WriteLine("returning HAPPY");
                    return "HAPPY";
                }
                else if (msg.Length == 0)
                {
                    throw new MoodAnalysisException(MoodAnalysisException.MoodList.Empty_Mood, "given mood is empty, please provide some mood");
                }
                else
                {
                    throw new MoodAnalysisException(MoodAnalysisException.MoodList.No_Such_Method, "no method found, enter proper method");
                }
                
            }
            catch (MoodAnalysisException)
            {
               throw new MoodAnalysisException(MoodAnalysisException.MoodList.Empty_Mood, "given mood is empty, please provide some mood");
                //return "HAPPY";
            }

            catch (NullReferenceException)
            {
                throw new MoodAnalysisException(MoodAnalysisException.MoodList.No_Mood, "no mood, enter proper me");

            }
        }
        /// <summary>
        /// Determines whether the specified <see cref="System.Object" />, is equal to this instance.
        /// </summary>
        /// <param name="obj">The <see cref="System.Object" /> to compare with this instance.</param>
        /// <returns>
        ///   <c>true</c> if the specified <see cref="System.Object" /> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public override bool Equals(object obj)
        {
            object moodanalyser = MoodAnalyserReflector.CreateInstance("MoodAnalyser","hfdhtjgfjyf");
            if (moodanalyser.GetType().Equals(obj.GetType()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(msg);
        }
    }
}
