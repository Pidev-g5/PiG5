using RecrutementDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RecrutementWeb.Models
{
    public class TestModel
    {
        public int TestId { get; set; }
        public String TestName { get; set; }

        public TypeTest TypeTest { get; set; }
        public String StatusTest { get; set; }
        public DateTime DateTest { get; set; }
        public virtual ICollection<Candidat> candidats { get; set; }
        public virtual ICollection<Question> questions { get; set; }

        public virtual ICollection<TestMark> Marks { get; set; }
        public int score { get; set; }
        public int idd { get; set; }
    }
}