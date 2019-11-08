using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RecrutementDomain.Entities
{
   public enum StatusCandidate { Accepted , Rejected , Waiting , WaitingForInterview}
    public class Candidat : User
    {
       
        public string Candidat_WebSite { get; set; }
        public string Candidat_Bio { get; set; }
        public string Candidat_facebookLink { get; set; }
        public string Candidat_linkedInLink { get; set; }
        public string Candidat_TwitterLink { get; set; }
        public StatusCandidate StatusCandidate { get; set; }

        public ICollection<String> Skills { get; set; }

        public Test Test { get; set; }
        [ForeignKey("Test")]
        public int? TestId { get; set; }//?:nullable

      
        public virtual ICollection<Certification> Certifications { get; set; }
        public virtual ICollection<WorkExperience> WorkExperiences { get; set; }
        public virtual ICollection<Education> Educations { get; set; }
        public virtual ICollection<TestMark> candidats { get; set; }


    }
}
