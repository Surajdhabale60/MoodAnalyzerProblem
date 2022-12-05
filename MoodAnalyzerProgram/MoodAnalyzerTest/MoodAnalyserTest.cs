using MoodAnalyserProgram;

namespace MoodAnalyserTest
{
    public class MoodAnalyserTest
    {
        [Test]
        public void GivenSadMood_WhenAnalyse_ShouldReturnSad()
        {
            //Arrange
            MoodAnalyser analyser = new MoodAnalyser("I am in a Sad Mood");
            //Act
            string result = analyser.AnalyseMood();
            Assert.AreEqual(result, "Sad");
        }

        [Test]
        public void GivenAnyMood_WhenAnalyse_ShouldReturnHappy()
        {
            //Arrange
            MoodAnalyser analyser = new MoodAnalyser("I am in a Any Mood");
            //Act
            string result = analyser.AnalyseMood();
            Assert.AreEqual(result, "Happy");
        }
        [Test]
        public void GivenNullMood_WhenAnalysed_ShouldReturnHappy()
        {
            //Arrange
            MoodAnalyser analyser = new MoodAnalyser(null);
            //Act
            string result = analyser.AnalyseMood();
            Assert.AreEqual(result, "Happy");
        }
    }
}