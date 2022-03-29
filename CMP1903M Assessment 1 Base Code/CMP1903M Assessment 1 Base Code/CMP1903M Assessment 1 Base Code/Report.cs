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
        public void outputConsole(List<int> input)
        {
            Console.WriteLine("Number of sentences: " + input[0]);
            Console.WriteLine("Number of vowels: " + input[1]);
            Console.WriteLine("Number of consonants: " + input[2]);
            Console.WriteLine("Number of upper case letters: " + input[3]);
            Console.WriteLine("Number of lower case letters: " + input[4]);
            Console.WriteLine("Number of Characters: " + input[5]);

        }
    }
}
