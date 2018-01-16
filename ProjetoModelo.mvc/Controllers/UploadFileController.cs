using System;
using System.IO;
using System.Linq;
using System.Web.Mvc;
using Ivan.LojaTudoEletro.ProjetoModelo.MVC.ViewsModels;

namespace Ivan.LojaTudoEletro.ProjetoModelo.MVC.Controllers
{
    public class UploadFileController : Controller
    {


        #region Propriedades

        string msgRetorno = string.Empty;
#pragma warning disable CS0414 // The field 'UploadFileController.strStatus' is assigned but its value is never used
        string strStatus = "ERRO";
#pragma warning restore CS0414 // The field 'UploadFileController.strStatus' is assigned but its value is never used

        #endregion


        private bool isValidContentType(String ContentType)
        {
            return ContentType.Equals("image/png") || ContentType.Equals("image/jpg") ||
                   ContentType.Equals("image/gif") ||
                   ContentType.Equals("image/jpeg");
        }

        public bool isValidContentLenght(int contentLength)
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
            var cont = 0;

            TempData["productViewModelTemp"] = productViewModel;
           


            var imagensFiles = productViewModel.ImagensProduto.ToList();


            try
            {

                foreach (var fotosList in imagensFiles)
                {
                    if (fotosList != null)
                    {
                        cont++;

                        if (!isValidContentType(fotosList.ContentType))
                        {
                            msgRetorno = "Permitido somente os formatos: JPG, JPEG, PNG e GIF";

                        }
                        else if (!isValidContentLenght(fotosList.ContentLength))
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
                        }
                    }
                }

             
            }


#pragma warning disable CS0168 // The variable 'e' is declared but never used
            catch (Exception e)
#pragma warning restore CS0168 // The variable 'e' is declared but never used
            {

            }


            return RedirectToAction("CreateProduct", "Product");
        }


    }
}
