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
         static void Main()
        {
            Input input = new Input();
            Analyse analyse = new Analyse();
            Report report = new Report();

            //define result integer
            string Result;
            //define a string that will be used for analysis
            string str;

            //gives the user the choice between the following
            Console.WriteLine("To pick your own TEXT being analysed please type 1");
            Console.WriteLine("To pick your own FILE being analysed please type 2");
            //result is assigned
            Result = Console.ReadLine();

            //allows user to input any text if 1 was selected
            if (Result == ("1"))
            {
                str = input.ManualTextInput();
                analyse.AnalyseText(str);
            }
            //locates file
            else if (Result == ("2"))
            {
                try
                {
                    string File = input.fileTextInput("CMP1903M Assessment 1 Test File.txt");
                    analyse.AnalyseText(File);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("the file was not found");
                }
            }
            //if user used different characters outside of 1 or 2
            else
            {
                Console.WriteLine("please only enter values of 1 or 2!");
            }
        }   
    }
}
