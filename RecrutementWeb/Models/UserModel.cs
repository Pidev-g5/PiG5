using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RecrutementWeb.Models
{
    public class UserModel
    {
        public int Id { get; set; }

        public String FName { get; set; }

        public String LName { get; set; }
        public String PhoneNumber { get; set; }
        public String StreetName { get; set; }
        public String City { get; set; }

        public String Country { get; set; }

        public String Email { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
