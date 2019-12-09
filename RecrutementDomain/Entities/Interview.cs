using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecrutementDomain.Entities
{
    public class Interview
    {

        [Key]
        public int InterviewId { get; set; }
        public DateTime Date { get; set; }
        public int Capacity { get; set; }
        public String Status { get; set; }

        public int PersonId { get; set; }
        [ForeignKey("person")]
        public virtual Person person { get; set; }
        public virtual ICollection<Reserved> reserveds { get; set; }
       
    }
}
