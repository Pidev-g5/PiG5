using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace RecrutementDomain.Entities
{
    public class Application
    {
        [Key]
        public int AppId { get; set; }
        public String Nom { get; set; }
        public String Prenom { get; set; }
        public int OfferId { get; set; }
        public int CandId { get; set; }
        public String ApplicationStatus { get; set; }
    }
}
