using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace SendMail.Controllers
{
    public class EmailController : Controller
    {
        // GET: Email
        [HttpGet]
        public ActionResult SendMail()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SendMail(string useremail)
        {
            string subject = "Hello";  
            string body = "<a href='https://www.w3schools.com'>Visit W3Schools.com!</a>";

            WebMail.Send(useremail, subject, body, null, null, null, true, null, null, null, null, null, null);
            ViewBag.msg = "Email send Successfully";
            return View();
        }
    }
}





//string[] mails = new string[]
//{
//    "tdynamite97@gmail.com", //maiua hoc vien 1
//    "daingu123@gmail.com", //mail hv 2,
//    "daidabanga@gmail.com" //mail hv 3
//};
//foreach(var mail in mails)
//{
//    WebMail.Send(mail, subject, body, null, null, null, true, null, null, null, null, null, null);

//}