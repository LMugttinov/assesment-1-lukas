using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CMP1903M_Assessment_1_Base_Code.Input;
using static CMP1903M_Assessment_1_Base_Code.Analyse;
using static CMP1903M_Assessment_1_Base_Code.Report;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Report
    {
        //Handles the reporting of the analysis
        //Maybe have different methods for different formats of output?
        //eg.   public void outputConsole(List<int>)
        public void OutputConsole(int numSentences, int numVowels, int numConsonants, int numUppercase, int numLowercase, int numCharacter)
        {
            Console.WriteLine("Number of sentences: " +  numSentences);
            Console.WriteLine("Number of vowels: " +  numVowels);
            Console.WriteLine("Number of consonants: " +  numConsonants);
            Console.WriteLine("Number of upper case letters: " +  numUppercase);
            Console.WriteLine("Number of lower case letters: " +  numLowercase);
            Console.WriteLine("Number of Characters: " +  numCharacter);

        }
    }
}
