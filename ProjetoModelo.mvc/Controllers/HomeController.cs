using System.Web.Mvc;
using Ivan.LojaTudoEletro.Services.Interfaces;

namespace Ivan.LojaTudoEletro.ProjetoModelo.MVC.Controllers
{
    public class HomeController : Controller

    {
        readonly IProductServices _productServices;

        public HomeController(IProductServices productServices)
        {
            this._productServices = productServices;
        }

        public ActionResult Index()
        {
            var model = _productServices.ReturnProductsSellof();
            return View("Index");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}
    }
}