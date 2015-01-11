using System.Web.Mvc;

namespace SimpleInvoiceSystem.WebSpaAngular.Controllers
{
    public class HomeController : SimpleInvoiceSystemControllerBase
    {
        public ActionResult Index()
        {
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
          //  return View("~/App/Main/views/login/login.cshtml"); //Layout of the angular application.
        }
	}
}