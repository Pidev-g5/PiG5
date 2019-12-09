using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecrutementDomain.Entities
{
   public class Person
    {
        public int PersonId { get; set; }
        public String FName { get; set; }
        public String LName { get; set; }
        public String PersonType { get; set; }
        public String Password { get; set; }
        public  String Email { get; set; }
        public virtual ICollection<Interview> interviews { get; set; }
       

    }
}
