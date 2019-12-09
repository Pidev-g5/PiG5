using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecrutementDomain.Entities
{
    public class Reserved
    {
        [Key]
        public int ReservedId { get; set; }
        public DateTime Date { get; set; }
        public int Capacity { get; set; }


        public int InterviewId { get; set; }
        [ForeignKey("interview")]
        public virtual Interview interview { get; set; }
        public virtual ICollection<Fixed> fixeds { get; set; }

    }
}
