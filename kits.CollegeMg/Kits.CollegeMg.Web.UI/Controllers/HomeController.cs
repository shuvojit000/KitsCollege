using Kits.CollegeMg.CollegeService.Repository;
using Kits.CollegeMg.CollegeService.Response;
using Kits.CollegeMg.Web.UI.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Kits.CollegeMg.Web.UI.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult LogIn() => View();
        [HttpPost]
        public ActionResult LogIn(StudentLogInModel model)
        {
            SecurityRepository rep = new SecurityRepository();
            if (ModelState.IsValid)
            {

                LogInRes res = rep.GetStudentLogIn(new CollegeService.Request.LogInReq {
                    DOB=model.DOB,
                    HSRollNo=model.HSRollNo
                });


                if (res!=null)
                {


                    CustomPrincipalSerializeModel serializeModel = new CustomPrincipalSerializeModel();
                    serializeModel.UserId = res.StudentID;
                    serializeModel.FirstName = "";
                    serializeModel.LastName = "";

                    string userData = JsonConvert.SerializeObject(serializeModel);
                    FormsAuthenticationTicket authTicket = new FormsAuthenticationTicket(
                    1,
                    DateTime.Now.ToString(),
                    DateTime.Now,
                    DateTime.Now.AddMinutes(15),
                    false, //pass here true, if you want to implement remember me functionality
                    userData);

                    string encTicket = FormsAuthentication.Encrypt(authTicket);
                    HttpCookie faCookie = new HttpCookie(FormsAuthentication.FormsCookieName, encTicket);
                    Response.Cookies.Add(faCookie);


                    return RedirectToAction("Index", "Home");

                }
            }

            return View();
        }

        [AllowAnonymous]
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Account", null);
        }


        
        public ActionResult Register() => View();


        [HttpPost]
        public ActionResult Register(RegistrationModel model)
        {


            return View();
        }
    }
}