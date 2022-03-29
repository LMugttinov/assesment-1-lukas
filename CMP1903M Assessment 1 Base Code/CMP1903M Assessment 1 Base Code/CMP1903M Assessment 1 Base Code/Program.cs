//Base code project for CMP1903M Assessment 1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Program
    {
        static void Main()
        {
            //define result integer
            int Result;
            //define a string that will be used for analysis
            string Str;
            //gives the user the choice between the following
            Console.WriteLine("To pick your own TEXT being analysed please type 1");
            Console.WriteLine("To pick your own FILE being analysed please type 2");
            //result is assigned
            Result = Console.Readline();

            //allows user to input any text if 1 was selected
            if (Result == 1)
            {
                Str = input.ManualTextInput();
                Analyse.AnalyseText(Str);
            }
            else if (Result == 2)
            {
                Console.WriteLine("What is the exact name of the file?")
                string file = Console.ReadLine();
                Str = input.FileTextInput(file)
                Analyse.AnalyseText(Str);
            }
            else
            {
                Console.WriteLine("please only enter values of 1 or 2!")
            }


            //Get either manually entered text, or text from a file


            //Create an 'Analyse' object
            //Pass the text input to the 'analyseText' method


            //Receive a list of integers back


            //Report the results of the analysis


            //TO ADD: Get the frequency of individual letters?


        }
        
        
    
    }
}
