﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecrutementDomain.Entities
{
    public class Blog
    {
        [Key]
        public int BlogId { get; set; }
        public String Contenu { get; set; }
        public int NbrLike { get; set; }
        public int NbrComment { get; set; }
        public String Titre { get; set; }
        public String Photo { get; set; }
        public DateTime DatePost { get; set; }
        public User User { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }


    }
}
