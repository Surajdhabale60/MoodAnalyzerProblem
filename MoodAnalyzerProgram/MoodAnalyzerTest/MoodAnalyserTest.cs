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
        public void GivenNullMood_WhenAnalyse_ShouldReturnHappy()
        {
            //Arrange
            MoodAnalyser analyser = new MoodAnalyser(null);
            //Act
            string result = analyser.AnalyseMood();
            Assert.AreEqual(result, "Happy");
        }
        [Test]
        public void GivenEmptyMood_WhenAnalyse_ShouldReturnHappy()
        {
            try
            {
                //Arrange
                MoodAnalyser analyse = new MoodAnalyser(String.Empty);
                //Act
                string result = analyse.AnalyseMood();
            }
            catch (MoodAnalyserException ex)
            {
                Assert.AreEqual("Message should not be Empty", ex.Message);
            }
        }
}