using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecrutementDomain.Entities
{
    public class Like
    {
        public int LikeId { get; set; }
        public User User { get; set; }
        public Blog Blog { get; set; }
        [ForeignKey("Blog")]
        public int BlogId { get; set; }
    }
}
