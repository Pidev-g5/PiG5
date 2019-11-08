using RecrutementDomain.Entities;
using RecrutementService.IServices;
using RecrutementService.Services;
using RecrutementWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RecrutementWeb.Controllers
{
    public class QuestionController : Controller
    {
        QuestionService iqs = new QuestionService();
        TestService ts = new TestService();
        // GET: Question
        public ActionResult Index()
        {
            List<QuestionModel> lq = new List<QuestionModel>();
            foreach (var qm in iqs.GetAll())
            {
                QuestionModel q = new QuestionModel();
                q.qQst = qm.qQst;
                q.QstId = qm.QstId;
                q.Rep1 = qm.Rep1;
                q.Rep2 = qm.Rep2;
                q.Rep3 = qm.Rep3;
                q.Rep4 = qm.Rep4;
                q.TestId = qm.TestId;
                q.RepCorrect = qm.RepCorrect;
                lq.Add(q);

            }
            return View(lq);
        }

        // GET: Question/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Question/Create
        public ActionResult Create()
        {
            var tests = ts.GetMany();
            ViewBag.TestId = new SelectList(tests, "TestId", "TestName");

            /*var offres = OS.GetMany();
            ViewBag.Offre_Id = new SelectList(offres, "Offre_Id", "Offre_Name");*/

            return View();
        }

        // POST: Question/Create
        [HttpPost]
        public ActionResult Create(QuestionModel qm)
        {
            Question q = new Question();
            q.qQst = qm.qQst;
            q.QstId = qm.QstId;
            q.Rep1 = qm.Rep1;
            q.Rep2 = qm.Rep2;
            q.Rep3 = qm.Rep3;
            q.Rep4 = qm.Rep4;
            q.TestId = qm.TestId;
            q.RepCorrect = qm.RepCorrect;
            iqs.Add(q);
            iqs.Commit();
            return RedirectToAction("ShowQuestions");

        }
        public ActionResult ShowQuestions()
        {
            return View(iqs.GetMany());
        }

        [HttpPost]
        public ActionResult ShowQuestions(int id)
        {
             var list = iqs.GetQuestiontByTest(id);


             return View(list);
           


        }
        /* public ActionResult ShowQuestions(int id)
         {
             var test = iqs.GetQuestiontByTest(id);
             List<QuestionModel> l = new List<QuestionModel>();
             /*foreach (var tm in test)
             {
                 QuestionModel tt = new QuestionModel();
                 tt.QstId = tm.QstId;
                 tt.qQst = tm.qQst;
                 tt.Rep1 = tm.Rep1;
                 tt.Rep2 = tm.Rep2;
                 tt.Rep3 = tm.Rep3;
                 tt.Rep4 = tm.Rep4;
                 tt.RepCorrect= tm.RepCorrect;
                 tt.TestId = tm.TestId;
                 l.Add(tt);
             }*/

        // return View(l);

        // }

        // GET: Question/Edit/5
        public ActionResult Edit(int id)
        {

            Question t = iqs.GetById(id);
            if (t == null)
            {
                return HttpNotFound();
            }
            return View(t);
        }

        // POST: Test/Edit/5
        [HttpPost]
        public ActionResult Edit(Question p)
        {
            Question p1 = iqs.GetById(p.QstId);
            p1.qQst = p.qQst;
            p1.Rep1 = p.Rep1;
            p1.Rep2 = p.Rep2;
            p1.Rep3 = p.Rep3;
            p1.Rep4 = p.Rep4;
            p1.RepCorrect = p.RepCorrect;

            if (ModelState.IsValid)
            {
                iqs.Update(p1);
                iqs.Commit();
                return RedirectToAction("ShowQuestions");
            }
            return RedirectToAction("ShowQuestions");
        }
        // GET: Question/Delete/5
        public ActionResult Delete(int id)
        {
           
            return View(iqs.GetById(id));
        }

        // POST: Question/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Question q)
        {
            q = iqs.GetById(id);
            iqs.Delete(q);
            iqs.Commit();
            return RedirectToAction("ShowQuestions");

        }
    }
}