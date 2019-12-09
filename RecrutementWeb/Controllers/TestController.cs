using HtmlAgilityPack;
using Microsoft.AspNet.Identity;
using RecrutementDomain.Entities;
using RecrutementService.IServices;
using RecrutementService.Services;
using RecrutementWeb.Models;
using Rotativa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace RecrutementWeb.Controllers
{
    public class TestController : Controller
    {
       TestService cs = new TestService();
        QuestionService iqs = new QuestionService();
        TestMarkService itm = new TestMarkService();

        // GET: Test
        /*  public String roleUser()
          {
              IUserService ps = new UserService();
              User p = new User();
              return ps.Get(t => t.Id == Int16.Parse(User.Identity.GetUserId())).role;
          }*/


        public ActionResult Index()
        {

            /* int user = Int16.Parse(User.Identity.GetUserId());
             var q = itm.GetAll();*/
            {
                TestModel tm = new TestModel();
                Test c = new Test();
                List<TestModel> l = new List<TestModel>();
                List<Question> lq = new List<Question>();
                c = cs.GetAll().OrderByDescending(t => t.questions.Count).First();
                tm.TestName = c.TestName;
                tm.TypeTest = c.TypeTest;
                lq = c.questions.OrderBy(x => Guid.NewGuid()).Take(20).ToList();
                tm.questions = lq;
                l.Add(tm);

                return View(l);
            }

        }


        public ActionResult TestPasse()
        {
            return View();
        }

      



       /* public async Task<ActionResult> ScrapTechnique()

        {
            var httpclient = new HttpClient();
            var htmldocument = new HtmlDocument();
            List<Question> list = new List<Question>();
            var url = "";
            var v = "";
            var k = 0;
            for (k = 1; k < 27; k++)
            {
                if (k == 1)
                {
                    url = "https://www.gkindiaonline.com/group/Computer-Science/Programming-Languages/";
                }
                else
                {
                    url = "https://www.gkindiaonline.com/group/Computer-Science/Programming-Languages/" + k;
                }
                var html = await httpclient.GetStringAsync(url);
                htmldocument.LoadHtml(html);

                var l = htmldocument.DocumentNode.SelectNodes("//div[@class='question']");
                var i = 0;
                foreach (var rep in l)
                {

                    Question r = new Question();
                    if (rep.SelectNodes(".//td[@width='99%']") != null)
                    {
                        var j = rep.SelectNodes(".//td[@width='99%']").ToArray();
                        var qst = rep.SelectNodes(".//div[@class='title']").First().SelectSingleNode(".//span").SelectSingleNode("following-sibling::text()[1]").InnerText.Trim();
                        r.qQst = qst;
                        r.Rep1 = j[0].InnerText.Trim();
                        r.Rep2 = j[1].InnerText.Trim();
                        r.Rep3 = j[2].InnerText.Trim();

                        r.Rep4 = j[3].InnerText.Trim();
                        var cor = rep.SelectNodes(".//div[@class='div-spacer']").First().SelectNodes(".//p");
                        var vv = cor[1].SelectSingleNode("following-sibling::text()[1]").InnerText.Trim();

                        r.RepCorrect = vv;
                        list.Add(r);

                        // r.repcorrect = cor[1].InnerHtml.Trim();
                        /*    var m= rep.ChildNodes.ToArray();
                        list.Add(m[3].InnerText.Trim());*/
                  /*  }
                    else
                    {
                        var j = rep.SelectNodes(".//td[@class='bix-td-option']").ToArray();
                        var qst = rep.SelectNodes(".//div[@class='title']").First().SelectSingleNode(".//span").SelectSingleNode("following-sibling::text()[1]").InnerText.Trim();

                        r.qQst = qst;
                        r.Rep1 = j[0].InnerText.Trim();
                        r.Rep2 = j[1].InnerText.Trim();
                        r.Rep3 = j[2].InnerText.Trim();
                        r.Rep4 = j[3].InnerText.Trim();
                        var cor = rep.SelectNodes(".//div[@class='div-spacer']").First().SelectNodes(".//p");
                        var vv = cor[1].SelectSingleNode("following-sibling::text()[1]").InnerText.Trim();
                        r.RepCorrect = vv;
                        list.Add(r);
                    }
                }
            }

            foreach (var r in list)
            {
                r.TestId = 2;
                iqs.Add(r);

            }
            iqs.Commit();

            return RedirectToAction("ShowTests");
        }*/



        public ActionResult ShowTests()
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
            return View(l);
        }



        // GET: Test/Details/5
        public ActionResult Details(int TestId)
         {
            var test = iqs.GetAll();
            List<QuestionModel> l = new List<QuestionModel>();
            foreach (var tm in iqs.GetAll())
            {
                QuestionModel tt = new QuestionModel();
                tt.QstId = tm.QstId;
                tt.qQst = tm.qQst;
                tt.Rep1 = tm.Rep1;
                tt.Rep2 = tm.Rep2;
                tt.Rep3 = tm.Rep3;
                tt.Rep4 = tm.Rep4;
                tt.RepCorrect = tm.RepCorrect;
                l.Add(tt);
            }
            return View(l);
        }
        [HttpPost]
        public ActionResult Details()
        {
            return RedirectToAction("ShowQuestions");

        }
        public ActionResult ScrappingTest()
        {
            var url = "https://www.mcqslearn.com/cs/computer-basics/asynchronous-and-synchronous-transmission-mcqs.php";
            var httpclient = new HttpClient();
            var htmldocument = new HtmlDocument();
            return View();
        }
        public ActionResult passerTest()
        {

            List<TestModel> l = new List<TestModel>();
            foreach (var i in cs.GetAll())
            {
                TestModel tm = new TestModel();
                tm.TestName = i.TestName;
                tm.TypeTest = i.TypeTest;
                l.Add(tm);
            }
            return View(l);
        }



        // GET: Test/Create
        public ActionResult Create()
        {

            var tests = cs.GetMany();
            ViewBag.CategoryId = new SelectList(tests, "TestId");
            return View();
        }
        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(Test p)
        {
            cs.Add(p);
            cs.Commit();
            return RedirectToAction("ShowTests");
        }




        // GET: Test/Edit/5
        public ActionResult Edit(int id)
        {

            Test t = cs.GetById(id);
            if (t == null)
            {
                return HttpNotFound();
            }
            return View(t);
        }

        // POST: Test/Edit/5
        [HttpPost]
        public ActionResult Edit(Test p)
        {
            Test p1 = cs.GetById(p.TestId);
            p1.TestName = p.TestName;
            p1.TypeTest = p.TypeTest;
          
            if (ModelState.IsValid)
            {
                cs.Update(p1);
                cs.Commit();
                return RedirectToAction("ShowTests");
            }
            return RedirectToAction("ShowTests");
        }




        // GET: Test/Delete/5
        public ActionResult Delete(int id)
        {
            
            return View(cs.GetById(id));
        }
        // POST: Product/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Test p)
        {

            p = cs.GetById(id);
            cs.Delete(p);
            cs.Commit();
            return RedirectToAction("ShowTests");
        }



        [HttpPost]
        public ActionResult Search(string filtre)
        {
            var list = cs.GetMany();


            // recherche
            if (!String.IsNullOrEmpty(filtre))
            {
                list = list.Where(m => m.TestName.ToString().Contains(filtre)).ToList();
            }

            return View(list);



        }


        public ActionResult TestResult()
        {
            {
                TestModel tm = new TestModel();
                Test c = new Test();
                List<TestModel> l = new List<TestModel>();
                List<Question> lq = new List<Question>();
                c = cs.GetAll().OrderByDescending(t => t.questions.Count).First();
                tm.TestName = c.TestName;
                tm.TypeTest = c.TypeTest;
                lq = c.questions.OrderBy(x => Guid.NewGuid()).Take(20).ToList();
                tm.questions = lq;
                l.Add(tm);

                return View(l);
            }
        }

        public ActionResult TestLang()
        {
            {
                TestModel tm = new TestModel();
                Test c = new Test();
                List<TestModel> l = new List<TestModel>();
                List<Question> lq = new List<Question>();
                c = cs.GetAll().OrderByDescending(t => t.questions.Count).First();
                tm.TestName = c.TestName;
                tm.TypeTest = c.TypeTest;
                lq = c.questions.OrderBy(x => Guid.NewGuid()).Take(20).ToList();
                tm.questions = lq;
                l.Add(tm);

                return View(l);
            }
        }

        public ActionResult TestPsy()
        {
            return View();
        }
         public ActionResult PrintAll ()
        {
            var q = new ActionAsPdf("TestPsy");
            return q;
        }
    }
   
}