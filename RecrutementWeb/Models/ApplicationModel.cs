using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RecrutementWeb.Models
{
    public class ApplicationModel
    {
        public int AppId { get; set; }
        public String Nom { get; set; }
        public String Prenom { get; set; }
        public int OfferId { get; set; }
        public int CandId { get; set; }
        public String ApplicationStatus { get; set; }
    }
}