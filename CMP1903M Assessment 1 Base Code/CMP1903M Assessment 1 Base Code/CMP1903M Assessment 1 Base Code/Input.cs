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
        string str2 = "";
        bool end = false;

        public string ManualTextInput()
        {
                //Asks user to type in text and will read value
                Console.WriteLine("Remember to press enter after evry sentence, and use an * on a seperate line if youd like to end. Enter text... ");
                while (end == false)
                {
                    str2 = Console.ReadLine();
                    str += str2;
                    if (str2 != "*") ;
                    {
                        str2 = Console.ReadLine();
                        str += str2;
                    }
                    if (str2 == "*")
                    {
                    end = true;
                    return str;
                    }
                }
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
