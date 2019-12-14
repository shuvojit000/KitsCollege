using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kits.CollegeMg.Web.UI.Controllers
{
    public class CollegeAdminController : BaseController
    {
        public CollegeAdminController()
        {

        }
        public ActionResult CollegeAdmission() => View();

    }
}