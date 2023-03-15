using Day29StateSensusProgram.StateSensus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day29StateSensusProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            string filePath = "C:\\Users\\Shiva027\\Desktop\\BridgeLabSolution\\Day29StateSensusProgram\\Day29StateSensusProgram\\StateSensus\\Book1.csv";
            StateCensusAnalyser analyser = new StateCensusAnalyser(filePath);
            int numberOfRecords = analyser.LoadDataFromCSV();
            Console.WriteLine("Number of records in the file: " + numberOfRecords);

        }
    }
}
