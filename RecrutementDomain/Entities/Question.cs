using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace RecrutementDomain.Entities
{
    public class Question
    {
        [Key]
        public int QstId { get; set; }
        public String qQst { get; set; }
        public String Rep1 { get; set; }
        public String Rep2 { get; set; }

        public String Rep3 { get; set; }

        public String Rep4 { get; set; }
        public String RepCorrect { get; set; }
        
        public int TestId { get; set; }
        [ForeignKey("test")]
        public virtual Test test { get; set; }
       
        
        

    }
}
