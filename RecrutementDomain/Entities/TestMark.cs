using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace RecrutementDomain.Entities
{
    public class TestMark
    {
        public int TestMarkId { get; set; }
        [Key, Column(Order = 0)]
        public int testId { get; set; }
        [Key, Column(Order = 1)]

        public int CandidatId { get; set; }
        
        public virtual Test t { get; set; }
       
        public virtual Candidat c { get; set; }
        public int mark { get; set; }
    }
}
