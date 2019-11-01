using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecrutementDomain.Entities
{
    public class Certification
    {
        [Key]
        public int Cerfication_Id { get; set; }
        public DateTime Cerfication_Date { get; set; }
        public string Cerfication_Link { get; set; }
        public string Cerfication_Name { get; set; }

        public int Candidat_Id { get; set; }
        [ForeignKey("Candidat_Id")]
        public virtual Candidat Candidat { get; set; }
    }
}
