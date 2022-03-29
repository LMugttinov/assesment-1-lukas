//Base code project for CMP1903M Assessment 1
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
    class Program
    {
        public static void Main()
        {
            Input input = new Input();
            Analyse analyse = new Analyse();

            //define result integer
            string Result;
            //define a string that will be used for analysis
            string str;
            //define a file that will turn into a string
            string file;

            //gives the user the choice between the following
            Console.WriteLine("To pick your own TEXT being analysed please type 1");
            Console.WriteLine("To pick your own FILE being analysed please type 2");
            //result is assigned
            Result = Console.ReadLine();

            //allows user to input any text if 1 was selected
            if (Result == ("1"))
            {
                 str = input.manualTextInput();
                = analyse.AnalyseText(str);
                
            }
            //locates file
            else if (Result == ("2"))
            {
                Console.WriteLine("File Found");
                str = input.fileTextInput("CMP1903M Assessment 1 Test File.txt");
                 = analyse.AnalyseText(str);
            }
            //if user used different characters outside of 1 or 2
            else
            {
                Console.WriteLine("please only enter values of 1 or 2!");
            }

            //Receive a list of integers back


            //Report the results of the analysis


            //TO ADD: Get the frequency of individual letters?


        }
        
        
    
    }
}
