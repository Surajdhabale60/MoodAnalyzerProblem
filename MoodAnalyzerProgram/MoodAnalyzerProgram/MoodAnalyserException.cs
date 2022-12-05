using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserProgram
{
    public class MoodAnalyserException : Exception
    {
        public enum MoodAnalyserExceptionType
        {
            NULL_MOOD, EMPTY_MOOD
        }
        public MoodAnalyserExceptionType type;
        public MoodAnalyserException(MoodAnalyserExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
