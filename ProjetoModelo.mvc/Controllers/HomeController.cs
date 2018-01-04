using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using AutoMapper;
using Ivan.LojaTudoEletro.Domain.Entities;
using Ivan.LojaTudoEletro.ProjetoModelo.MVC.ViewsModels;
using Ivan.LojaTudoEletro.ProjetoModelo.MVC.AutoMapper;
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
            var productViewModel = Mapper.Map<IEnumerable<Product>, IEnumerable<ProductViewModel>>(_productServices.ReturnProductsSellof());

            return View("Index", productViewModel);
        }



        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}