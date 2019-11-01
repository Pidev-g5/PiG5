using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecrutementDomain.Entities
{
    public class WorkExperience
    {
        [Key]
        public int WorkExperience_Id { get; set; }
        public string WorkExperience_Name { get; set; }
        public int WorkExperience_StartDate { get; set; }
        public int WorkExperience_EndDate { get; set; }
        public string WorkExperience_Location { get; set; }
        public string WorkExperience_Description { get; set; }

        public int Candidat_Id { get; set; }
        [ForeignKey("Candidat_Id")]
        public virtual Candidat Candidat { get; set; }
    }
}
