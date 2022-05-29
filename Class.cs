using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineQuiz
{
    public class Questions
    {
        public string que;
        public string option1;
        public string option2;
        public string option3;
        public string option4;
        public string correct;
        public Questions()
        {
        }
        public Questions(string que, string option1, string option2, string option3, string option4, string correct)
        {
            this.que = que;
            this.option1 = option1;
            this.option2 = option2;
            this.option3 = option3;
            this.option4 = option4;
            this.correct = correct;
        }

        public string Que { get => que; set => que = value; }
        public string Option1 { get => option1; set => option1 = value; }
        public string Option2 { get => option2; set => option2 = value; }
        public string Option3 { get => option3; set => option3 = value; }
        public string Option4 { get => option4; set => option4 = value; }
        public string Correct { get => correct; set => correct = value; }
    }
}
