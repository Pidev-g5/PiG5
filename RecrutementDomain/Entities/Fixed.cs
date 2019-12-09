using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecrutementDomain.Entities
{
    public class Fixed
    {
        [Key]
        public int FixedId { get; set; }
        public DateTime Date { get; set; }
        public int Capacity { get; set; }


        public int ReservedId { get; set; }
        [ForeignKey("reserved")]
        public virtual Reserved reserved { get; set; }
    }
}
