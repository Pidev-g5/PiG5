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
    public class TestMarkService : Service<TestMark>, ITestMarkService
    {
        private static IDataBaseFactory dbfactor = new DataBaseFactory();
        private static IUnitOfWork wow = new UnitOfWork(dbfactor);
        IDataBaseFactory dbfactory = null;
        public TestMarkService() : base(wow)
        {

        }
    }
}
