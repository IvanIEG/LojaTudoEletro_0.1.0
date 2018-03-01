using System;
using System.IO;
using System.Linq;
using System.Web.Mvc;
using Ivan.LojaTudoEletro.ProjetoModelo.MVC.ViewsModels;
using Ivan.LojaTudoEletro.ProjetoModelo.MVC.Controllers;
namespace Ivan.LojaTudoEletro.ProjetoModelo.MVC.Controllers
{
    public class UploadFileController : Controller
    {


        #region Propriedades

        string msgRetorno = string.Empty;

        string strStatus = "ERRO";


        #endregion


        private bool isValidContentType(String ContentType)
        {
            return ContentType.Equals("image/png") || ContentType.Equals("image/jpg") ||
                   ContentType.Equals("image/gif") ||
                   ContentType.Equals("image/jpeg");
        }

        public bool IsValidContentLenght(int contentLength)
        {
            return (contentLength / 8192) / 8192 < 8;
        }
        /// <summary>
        /// Responsável por validar a imagem que será relacionada ao produto
        /// </summary>
        /// <param name="fotos">fotos para serem validade</param>
        /// <returns>Json que será usado em uma chamada ajax para validar a imagem na criação de um produto</returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Process(ProductViewModel productViewModel)
        {

            TempData["productViewModelTemp"] = productViewModel;

            if (ModelState.IsValid)
            {
                string msg = "error";
                var cont = 0;



                var imagensFiles = productViewModel.ImagensProduto.ToList();


                foreach (var fotosList in imagensFiles)
                {
                    if (fotosList != null)
                    {
                        cont++;

                        if (!isValidContentType(fotosList.ContentType))
                        {
                            msgRetorno = "Permitido somente os formatos: JPG, JPEG, PNG e GIF";

                        }
                        else if (!IsValidContentLenght(fotosList.ContentLength))
                        {
                            msgRetorno = "O tamanho máximo permitido é de 8mb.";


                        }
                        else if (fotosList.ContentLength > 0)
                        {

                            var fileName = Path.GetFileName(fotosList.FileName);
                            var path = Path.Combine(Server.MapPath("~/content/uploads/fotosProdutos"), fileName);

                            fotosList.SaveAs(path);


                            var imagem = new ImagemViewModel();
                            if (cont == 1)
                            {
                                imagem.ehPrincipal = true;
                            }
                            imagem.UrlImagem = fileName;

                            productViewModel.Imagens.Add(imagem);

                            msg = "ok";
                        }
                    }
                 
                }
                return RedirectToAction("CreateProduct", "Product");

            }
            return View("~/views/Product/Create.cshtml",productViewModel);
        }
       
    }


}

