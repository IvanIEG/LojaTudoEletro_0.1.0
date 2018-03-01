using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ivan.LojaTudoEletro.ProjetoModelo.MVC.Controllers
{
    public class CarrinhoDeComprasController : Controller
    {
        // GET: CarrinhoDeCompras
        public ActionResult Index()
        {
            return View();
        }
    }
}