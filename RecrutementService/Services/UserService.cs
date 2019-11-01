using RecrutementData.Infrastructure;
using RecrutementDomain.Entities;
using RecrutementService.IServices;
using RecrutementServicePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecrutementService.Services
{
    class UserService : Service<User>, IUserService
    {
        private static IDataBaseFactory dbfactor = new DataBaseFactory();
        private static IUnitOfWork wow = new UnitOfWork(dbfactor);
        IDataBaseFactory dbfactory = null;
        public UserService() : base(wow)
        {

        }
        public User FindRoleByName(string name)
        {
            IEnumerable<User> ls = this.GetMany().OrderBy(p => p.FName).Where(p => p.UserName == name).Take(1);
            User c = new User();
            foreach (var i in ls)
            {
                c.FName = i.FName;
                c.Role = i.Role;
            }
            return c;
        }
    }
}

