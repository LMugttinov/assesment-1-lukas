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
    public class Analyse
    {
        
        //Method: analyseText
        //Arguments: string
        //Returns: list of integers
        //Calculates and returns an analysis of the text
        public List<int> AnalyseText(string str)
        {
            //List of integers to hold the first five measurements:
            //1. Number of sentences
            int numSentences = 0;
            Report report = new Report();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '!' || str[i] == '.' || str[i] == '?')
                {
                    numSentences++;
                }
            }
            //2. Number of vowels
            int numVowels = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'a' || str[i] == 'A' || str[i] == 'e' || str[i] == 'E' || str[i] == 'i' || str[i] == 'I' || str[i] == 'o' || str[i] == 'O' || str[i] == 'u' || str[i] == 'U')
                {
                    numVowels++;
                }
            }
            //3. Number of consonants
            int numConsonants = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'b' || str[i] == 'B' || str[i] == 'c' || str[i] == 'C' || str[i] == 'd' || str[i] == 'D' || str[i] == 'f' || str[i] == 'F' || str[i] == 'g' || str[i] == 'G' || str[i] == 'h' || str[i] == 'H' || str[i] == 'j' || str[i] == 'J' || str[i] == 'k' || str[i] == 'K' || str[i] == 'l' || str[i] == 'L' || str[i] == 'm' || str[i] == 'M' || str[i] == 'n' || str[i] == 'N' || str[i] == 'p' || str[i] == 'P' || str[i] == 'q' || str[i] == 'Q' || str[i] == 'r' || str[i] == 'R' || str[i] == 's' || str[i] == 'S' || str[i] == 't' || str[i] == 'T' || str[i] == 'v' || str[i] == 'V' || str[i] == 'w' || str[i] == 'W' || str[i] == 'x' || str[i] == 'X' || str[i] == 'y' || str[i] == 'Y' || str[i] == 'z' || str[i] == 'Z')
                {
                    numConsonants++;
                }
            }
            //4. Number of upper case letters
            int numUppercase = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'A' || str[i] == 'B' || str[i] == 'C' || str[i] == 'D' || str[i] == 'E' || str[i] == 'F' || str[i] == 'G' || str[i] == 'H' || str[i] == 'I' || str[i] == 'J' || str[i] == 'K' || str[i] == 'L' || str[i] == 'M' || str[i] == 'N' || str[i] == 'O' || str[i] == 'P' || str[i] == 'Q' || str[i] == 'R' || str[i] == 'S' || str[i] == 'T' || str[i] == 'U' || str[i] == 'V' || str[i] == 'W' || str[i] == 'X' || str[i] == 'Y' || str[i] == 'Z')
                {
                    numUppercase++;
                }
            }
            //5. Number of lower case letters
            int numLowercase = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'a' || str[i] == 'b' || str[i] == 'c' || str[i] == 'd' || str[i] == 'e' || str[i] == 'f' || str[i] == 'g' || str[i] == 'h' || str[i] == 'i' || str[i] == 'j' || str[i] == 'k' || str[i] == 'l' || str[i] == 'm' || str[i] == 'n' || str[i] == 'o' || str[i] == 'p' || str[i] == 'q' || str[i] == 'r' || str[i] == 's' || str[i] == 't' || str[i] == 'u' || str[i] == 'v' || str[i] == 'w' || str[i] == 'x' || str[i] == 'y' || str[i] == 'z')
                {
                    numLowercase++;
                }
            }
            //6. Number of characters not including whitespace
            int numCharacter = 0;
            str = str.Replace(" ", "");
            {
                foreach (char c in str)
                {
                    numCharacter++;
                }


                List<int> values = new List<int>();
                //outputs all found values to Report
                report.OutputConsole(numSentences, numVowels, numConsonants, numUppercase, numLowercase, numCharacter);

                return values;
                
            }

        }
    }
}

