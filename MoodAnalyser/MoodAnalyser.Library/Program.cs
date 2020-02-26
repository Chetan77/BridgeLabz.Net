using System;

namespace MoodAnalyserLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MoodAnalyserReflector.CreateInstance("MoodAnalyser", "i am in happy mood", "AnalyseMood");
        }
    }
}
