using Microsoft.AspNet.Identity;
using RecrutementDomain.Entities;
using RecrutementService.IServices;
using RecrutementService.Services;
using RecrutementWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace RecrutementWeb.Controllers
{
    public class ApplicationController : Controller
    {
        ApplicationService aps = new ApplicationService();

        public ActionResult Index()
        {
            return View(aps.GetMany());
        }

        [HttpPost]
        public ActionResult Index(string filtre)
        {
            var list = aps.GetMany();


            // recherche
           /* if (!String.IsNullOrEmpty(filtre))
            {
                list = list.Where(m => m.Name.ToString().Equals(filtre)).ToList();
            }*/

            return View(list);



        }

        // GET: Test/Create
        public ActionResult Create()
        {

            var Apps = aps.GetMany();
            ViewBag.CategoryId = new SelectList(Apps, "AppId");
            return View();
        }
        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(Application a)
        {
            aps.Add(a);
            aps.Commit();
            return RedirectToAction("Index");
        }

        public ActionResult ShowApp()
        {
            return View(aps.GetMany());
        }

        [HttpPost]
        public ActionResult ShowApp(string filtre)
        {
            var list = aps.GetMany();


            // recherche
            /* if (!String.IsNullOrEmpty(filtre))
             {
                 list = list.Where(m => m.Name.ToString().Equals(filtre)).ToList();
             }*/

            return View(list);



        }

        //Show Appl For Candidate
        public ActionResult ShowAppCand()
        {
            return View(aps.GetMany());
        }

        [HttpPost]
        public ActionResult ShowAppCand(string filtre)
        {
            var list = aps.GetMany();


            // recherche
            /* if (!String.IsNullOrEmpty(filtre))
             {
                 list = list.Where(m => m.Name.ToString().Equals(filtre)).ToList();
             }*/

            return View(list);



        }

        public ActionResult Accepted(int id  )

        {
           
            return View();
            // return View(t);
            //aps.GetById(app.AppId);
            /* if (app.ApplicationStatus.Equals("Accepted"))
             {
                 return RedirectToAction("Accepted");

             }
             else
             {
                 return RedirectToAction("Rejected");
             }*/
        }

        [HttpPost]
        public ActionResult Accepted(Application p)
        {
            Application p1 = aps.GetById(p.AppId);
            if (p1.ApplicationStatus.Equals("Accepted"))
            {
                return RedirectToAction("Accepted");
            }
            else if(p1.ApplicationStatus.Equals("Rejected"))
            {
                return RedirectToAction("Rejected");
            }
            return RedirectToAction("Rejected");
        }


        public ActionResult Rejected(int id)

        {

            return View();
            // return View(t);
            //aps.GetById(app.AppId);
            /* if (app.ApplicationStatus.Equals("Accepted"))
             {
                 return RedirectToAction("Accepted");

             }
             else
             {
                 return RedirectToAction("Rejected");
             }*/
        }

        [HttpPost]
        public ActionResult Rejected(Application p)
        {
            Application p1 = aps.GetById(p.AppId);
            if (p1.ApplicationStatus.Equals("Accepted"))
            {
                return RedirectToAction("Accepted");
            }
            else if (p1.ApplicationStatus.Equals("Rejected"))
            {
                return RedirectToAction("Rejected");
            }
            return RedirectToAction("Rejected");
        }

        // GET: Test/Edit/5
        public ActionResult Confirmer(int id)
        {

            Application t = aps.GetById(id);
            if (t == null)
            {
                return HttpNotFound();
            }
            return View(t);
        }

        // POST: Test/Edit/5
        [HttpPost]
        public ActionResult Confirmer(Application p)
        {
            Application p1 = aps.GetById(p.AppId);
            p1.ApplicationStatus = p.ApplicationStatus;
            

            if (ModelState.IsValid)
            {
                aps.Update(p1);
                aps.Commit();
                var verifyurl = "/Signup/VerifiyAccount/";
                var link = Request.Url.AbsolutePath.Replace(Request.Url.PathAndQuery, verifyurl);

                var fromEmail = new MailAddress("fatma.dayeg@esprit.tn", "CareerUp");
                var toEmail = new MailAddress("dayeg.fatma@gmail.com");
                var FromEmailPassword = "172jft1681";

                string subject = "Response On Job Application";

                string body = "We have respond on your job application! Go check your Result. " +
                    "<br/><a href = '" + link + "'>" + link + "</a>";

                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromEmail.Address, FromEmailPassword),
                    Timeout = 20000
                };
                using (var message = new MailMessage(fromEmail, toEmail)
                {
                    Subject = subject,
                    Body = body,
                    IsBodyHtml = true

                }) smtp.Send(message);
                return RedirectToAction("ShowApp");
            }
            return RedirectToAction("ShowApp");
        }


        // GET: Test/Delete/5
        public ActionResult Delete(int id)
        {

            return View(aps.GetById(id));
        }
        // POST: Product/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Application p)
        {

            p = aps.GetById(id);
            aps.Delete(p);
            aps.Commit();
            return RedirectToAction("ShowApp");
        }


    }
}