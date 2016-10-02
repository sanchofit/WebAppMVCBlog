using System.Web.Mvc;

namespace WebAppMVCBlog.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration 
    {
        public override string AreaName => "Admin";

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Admin_default",
                "Admin/{controller}/{action}/{id}",
                new { controller = "Login", action = "Index", id = UrlParameter.Optional },
                namespaces: new string[] { "WebAppMVCBlog.Areas.Admin.Controllers" }
            );
        }
    }
}