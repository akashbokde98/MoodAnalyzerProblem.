using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace MoodAnalyzer
{
    public class MoodAnalyser
    {
        public string message;
        public MoodAnalyser(string message) 
        {
            this.message = message;
        }
        public MoodAnalyser()
        {
            this.message = message;
        }
        public string AnalyseMood()
        {
            if(message.Contains("Sad"))
            {
                return "Sad";
            }
            else
            {
                return "Happy";
            }
        }
    }
}
