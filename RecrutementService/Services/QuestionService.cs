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
    public class QuestionService : Service<Question>, IQuestionService
    {
         static IDataBaseFactory dbfactor = new DataBaseFactory();
         static IUnitOfWork wow = new UnitOfWork(dbfactor);
       // IDataBaseFactory dbfactory = null;
        public QuestionService() : base(wow)
        {

        }

        public IEnumerable<Question> GetQuestiontByTest(int TestId)
        {
           
            return GetMany(p => p.test.TestId==TestId);

        }
    }
}
