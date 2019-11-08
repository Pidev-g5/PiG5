using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RecrutementWeb.Models
{
    public class QuestionModel
    {
        public int QstId { get; set; }
        public String qQst { get; set; }
        public String Rep1 { get; set; }
        public String Rep2 { get; set; }

        public String Rep3 { get; set; }

        public String Rep4 { get; set; }
        public String RepCorrect { get; set; }

        public int TestId { get; set; }
    }
}