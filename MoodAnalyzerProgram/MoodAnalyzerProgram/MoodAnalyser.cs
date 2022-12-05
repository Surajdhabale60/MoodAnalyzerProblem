using static MoodAnalyserProgram.MoodAnalyserException;

namespace MoodAnalyserProgram
{
    public class MoodAnalyser
    {
        string message;
        public MoodAnalyser(string message)
        {
            this.message = message;
        }
        public string AnalyseMood()
        {
            try
            {
                if (message.Equals(string.Empty))
                {
                    throw new MoodAnalyserException(MoodAnalyserExceptionType.EMPTY_MOOD, "Message should not be Empty");
                }
                if (message.Contains("Sad"))
                {
                    return "Sad";
                }
                else
                {
                    return "Happy";
                }
            }
            catch (NullReferenceException)
            {
                throw new MoodAnalyserException(MoodAnalyserExceptionType.NULL_MOOD, "Message should not be null");
            }
        }
    }
}