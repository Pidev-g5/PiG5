using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace RecrutementDomain.Entities
{
    public class Discussion
    {
        
        [Key]
        public int id { get; set; }
        public User p { get; set; }
        public virtual ICollection<Message> listMessage { get; set; }
    }
}
