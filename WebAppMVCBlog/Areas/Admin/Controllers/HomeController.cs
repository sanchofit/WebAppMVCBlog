using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppMVCBlog.Areas.Admin.Models.Attributes;
using WebAppMVCBlog.Models.ORM.Context;
using WebAppMVCBlog.Models.ORM.Entity;

namespace WebAppMVCBlog.Areas.Admin.Controllers
{
    [LoginControl]
    public class HomeController : Controller
    {
        // GET: Admin/Home
        public ActionResult Index()
        {
            //BlogContext db = new BlogContext();
            //string email = HttpContext.User.Identity.Name;
            //AdminUser adminUser = db.AdminUsers.FirstOrDefault(x=>x.EMail == email);
            //string name = adminUser.Name;
            //string surname = adminUser.Surname;


            return View();
        }
    }
}