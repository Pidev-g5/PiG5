using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecrutementDomain.Entities
{
    public class Education
    {
        [Key]
        public int Education_Id { get; set; }
        public string Education_Name { get; set; }
        public int Education_StartDate { get; set; }
        public int Education_EndDate { get; set; }
        public string Education_Location { get; set; }
        public string Education_Description { get; set; }



        public int Candidat_Id { get; set; }
        [ForeignKey("Candidat_Id")]
        public virtual Candidat Candidat { get; set; }
    }
}
