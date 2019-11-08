using RecrutementDomain.Entities;
using RecrutementService.IServices;
using RecrutementService.Services;
using RecrutementWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace RecrutementWeb.Controllers
{
    public class TestApiController : ApiController
    {
        ITestService cs = new TestService();
        IQuestionService iqs = new QuestionService();
        ITestMarkService itm = new TestMarkService();
        [Route("api/ShowTest")]
        [HttpGet]
        public IHttpActionResult GetShowTest()
        {

            TestModel tm = new TestModel();
            Test c = new Test();
            List<TestModel> l = new List<TestModel>();
            List<Question> lq = new List<Question>();
            c = cs.GetAll().First();
            tm.TestName = c.TestName;
            tm.TypeTest = c.TypeTest;
            lq = c.questions.OrderBy(x => Guid.NewGuid()).Take(20).ToList();
            tm.questions = lq;
            l.Add(tm);
            return Ok(tm);

        }
        [Route("api/TestMark")]

        [HttpPost]

        public IHttpActionResult AjouterTestMark(int score, int testid, int userid)
        {
            TestMark Mark = new TestMark();
            Mark.mark = score;
            Mark.testId = testid;
            Mark.CandidatId = userid;
            itm.Add(Mark);
            itm.Commit();
            return Ok();
        }
        [Route("api/ShowAllTest")]

        [HttpGet]

        public IHttpActionResult ShowAllTest()
        {
            var test = cs.GetAll();
            List<TestModel> l = new List<TestModel>();
            foreach (var tm in cs.GetAll())
            {
                TestModel tt = new TestModel();
                tt.TestId = tm.TestId;
                tt.TestName = tm.TestName;
                tt.TypeTest = tm.TypeTest;
                tt.questions = tm.questions;
                l.Add(tt);
            }
            return Ok(l);
        }
        /*
        public IHttpActionResult ShowTestDetail(int id)
        {
            var tm = cs.Get(t => t.id == id);

            TestModel tt = new TestModel();
            tt.TestId = tm.TestId;
            tt.TestName = tm.TestName;
            tt.TypeTest = tm.TypeTest;
            tt.questions = tm.questions;

            return Ok(tt);
        }
        [Route("api/ShowTestMark")]

        [HttpGet]
        
        public IHttpActionResult showTestMark(int user)
        {
            TestMark s = itm.Get(t => t.CandidatId == user);
            TestMarkModel tmm = new TestMarkModel();
            tmm.mark = s.mark;
            tmm.testId = s.testId;
            tmm.CandidatId = user;
            return Ok(tmm);

        }*/



    }
}