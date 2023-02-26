using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzer
{
    public class MoodAnalyser
    {
        public string message;
        public string mood = null;
        public MoodAnalyser(string message)
        {
            this.message = message;
        }
        public string AnalyseMood()
        {
            try
            {
                if (message.Contains(mood))
                {
                    return "Sad";
                }
                throw new Exception();
            }
            catch(Exception)
            {
                Console.WriteLine("Entered Invalid or Null Mood Name");
            }
            return "Happy";
        }
    }
}
