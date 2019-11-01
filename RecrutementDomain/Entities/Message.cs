using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecrutementDomain.Entities
{
    public class Message
    {

        [Key]
        public int MessageId { get; set; }
        public String Content { get; set; }
        public DateTime MessageDate { get; set; }
        public virtual Discussion d { get; set; }
    }
}
