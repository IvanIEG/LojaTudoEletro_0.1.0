using System.Collections.Generic;
using System.Web.Mvc;
using Ivan.LojaTudoEletro.Domain.Entities;
using Ivan.LojaTudoEletro.Services;

namespace Ivan.LojaTudoEletro.ProjetoModelo.MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var products = new List<Product>();
            var productServices = new ProductServices();
            products = productServices.ReturnProductsSellof();

            return View("Index", products);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}