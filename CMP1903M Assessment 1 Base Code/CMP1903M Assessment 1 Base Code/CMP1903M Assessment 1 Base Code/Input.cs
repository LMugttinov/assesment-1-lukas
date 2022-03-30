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
    public class Input
    {
        //define String
        string str = "";
        
        public string ManualTextInput()
        {
            //Asks user to type in text and will read value
            Console.WriteLine("Enter text... ");
            str = Console.ReadLine();
            return str;
        }
        public string fileTextInput(string filename)
        {
            //Finds file and reads file
            str = File.ReadAllText(filename);
            return str;
        }

    }
}
