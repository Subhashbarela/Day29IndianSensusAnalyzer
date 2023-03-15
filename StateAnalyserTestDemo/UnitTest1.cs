using Day29StateSensusProgram.StateSensus;

namespace StateAnalyserTestDemo
{
   
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void LoadDataFromCSV_ShouldReturnNumberOfRecords()
        {
            // Arrange
            string filePath = "C:\\Users\\Shiva027\\Desktop\\BridgeLabSolution\\Day29StateSensusProgram\\Day29StateSensusProgram\\StateSensus\\Book1.csv";
            StateCensusAnalyser analyser = new StateCensusAnalyser(filePath);
            int expectedNumberOfRecords = 5;

            // Act
            int actualNumberOfRecords = analyser.LoadDataFromCSV();

            // Assert
            Assert.AreEqual(expectedNumberOfRecords, actualNumberOfRecords);
        }
    }
}