using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using AutoMapper;
using Ivan.LojaTudoEletro.Domain.Entities;
using Ivan.LojaTudoEletro.ProjetoModelo.MVC.ViewsModels;
using Ivan.LojaTudoEletro.Services.Interfaces;

using FormCollection = Microsoft.Owin.FormCollection;

namespace Ivan.LojaTudoEletro.ProjetoModelo.MVC.Controllers
{
    public class ProductController : Controller
    {

        readonly IProductServices _productServices;

        public ProductController(IProductServices productServices)
        {
            this._productServices = productServices;
        }

        // GET: Product
        public ActionResult ListProducts()
        {
            var listProductViewModels = Mapper.Map<List<Product>, List<ProductViewModel>>(_productServices.GetAllProducts().ToList());

            return View("ListProducts", listProductViewModels);
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            var product = _productServices.GetProduct(id);

            var productViewModel = Mapper.Map<Product, ProductViewModel>(product);

            return View("Details", productViewModel);
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            return View();
        }



        public ActionResult CreateProduct()
        {
            try
            {
                var productViewModel = TempData["productViewModelTemp"] as ProductViewModel;

                var productDomain = Mapper.Map<ProductViewModel, Product>(productViewModel);

                _productServices.AddProduct(productDomain);

                return RedirectToAction("ListProducts");
            }

            catch
            {
                return RedirectToAction("Create");
            }


        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            var productViewModel = Mapper.Map<Product, ProductViewModel>(_productServices.GetProduct(id));


            return View(productViewModel);
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, ProductViewModel productViewModel)
        {
            try
            {
                var productDomain = _productServices.GetProduct(id);

                _productServices.EditProduct(productDomain);

                return RedirectToAction("ListProducts");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {

            var productViewModel = Mapper.Map<Product, ProductViewModel>(_productServices.GetProduct(id));

            return View(productViewModel);
        }

        // POST: Product/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, ProductViewModel product)
        {
            try
            {

                var productDomain = _productServices.GetProduct(id);

                _productServices.DeleteProduct(productDomain);


                return RedirectToAction("ListProducts");
            }

            catch (Exception error)
            {
                return View();
            }
        }
    }
}
