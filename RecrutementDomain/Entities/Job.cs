using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecrutementDomain.Entities
{
    public enum JobType { FullTime, PartTime , Intership}
    public enum Experience { Intership , EntryLevel , Associate , Senior , Director}
    public enum Gender { Male , Female }
    public enum Qualification { Certificate , Bachelor , Master , Engineering}
    public class Job
    {
        [Key]
        public int IdJob { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime PostedDate { get; set; }
        public DateTime Deadline { get; set; }
        public JobType JobType { get; set; }
        public Experience Experience { get; set; }
        public Gender Gender { get; set; }
        public string Industry { get; set; }
        public float Salary { get; set; }
        public Qualification Qualification { get; set; }
        public int? CompanyId { get; set; }//?:nullable
        
        [ForeignKey("CompanyId")]
        public virtual Company Company { get; set; }




    }
}
