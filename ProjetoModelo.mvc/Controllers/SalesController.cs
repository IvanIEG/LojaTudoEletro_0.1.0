using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ivan.LojaTudoEletro.ProjetoModelo.MVC.ServiceReference1;

namespace Ivan.LojaTudoEletro.ProjetoModelo.MVC.Controllers
{
    public class SalesController : Controller
    {
        // GET: Sales
        public ActionResult Index()
        {
            return View();
        }

        
        public JsonResult CorreiosCalc(string cep)
        {
            CalcPrecoPrazoWSSoapClient wscorreios = new CalcPrecoPrazoWSSoapClient();

            //cResultado retornoCorreios = wscorreios;

            return Json("");
        }
    }
}