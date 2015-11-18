using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTER
{
    class TEST
    {
        string Quest;
        string[] Answer;
        string EndAnswer; 
        public TEST ()
        {
            this.Quest = Quest;
            this.Answer = Answer;
            this.EndAnswer = EndAnswer;
        }
        public TEST AddTestToDB(string Quest, params string[] Answers)
        {
            TEST test = new TEST();
            test.Quest = Quest;
            test.Answer = Answer;
            test.EndAnswer = EndAnswer;
            return test;
        }
    
    }
}
