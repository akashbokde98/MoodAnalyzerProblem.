using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzer
{
    public class MoodAnalyser
    {
        public string message;
        //public string mood;
        public MoodAnalyser(string message)
        {
            this.message = message;
        }

        //Giving NULL Mood
        public string AnalyseMood1()
        {
            //Console.WriteLine("Enter Mood Name-");
            //string mood = Console.ReadLine();
            string mood = null;
            try
            {
                if (message.Contains(mood))
                {
                    return "Sad";
                }
                else
                {
                    if (mood != null)
                        return "Happy";
                }
                throw new MoodAnalysisException(ExceptionMessage.NullMoodName);
            }
            catch (MoodAnalysisException)
            {
                Console.WriteLine("Entered Invalid Mood Name");
            }
            return "";
        }

        //Giving Empty Mood
        public string AnalyseMood2()
        {
            //Console.WriteLine("Enter Mood Name-");
            //string mood = Console.ReadLine();
            string mood = "";
            try
            {
                if (message.Contains(mood) && mood != "")
                {
                    return "Sad";
                }
                else
                {
                    if (mood != "")
                        return "Happy";
                }
                throw new MoodAnalysisException(ExceptionMessage.EmptyMoodName);
            }
            catch (MoodAnalysisException)
            {
                Console.WriteLine("Entered Invalid Mood Name");
            }
            return "";
        }
    }
}
