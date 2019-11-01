using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecrutementDomain.Entities
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }
        public String Contenu { get; set; }

        public User User { get; set; }

        
        public int BlogId { get; set; }

        [ForeignKey("BlogId")]
        public Blog Blog { get; set; }

    }
}
