using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace RecrutementDomain.Entities
{
    public enum TypeTest
    { OnLineTest, LanguageTest , PsychotechnicalTest }

    public enum StatusTest { Validated , Failed}
    public class Test
    {

        [Key]
        public int TestId { get; set; }
        public String TestName { get; set; }

        public TypeTest TypeTest { get; set; }

        public StatusTest StatusTest { get; set; }
      /*  public virtual Question question { get; set; }
        [ForeignKey("question")]
        public int qstId { get; set; }*/
        public DateTime DateTest { get; set; }
        public int score { get; set; }

        public virtual ICollection<Candidat> candidats { get; set; }
        public virtual ICollection<Question> questions { get; set; }
        public virtual ICollection<TestMark> Marks { get; set; }
    }
}
