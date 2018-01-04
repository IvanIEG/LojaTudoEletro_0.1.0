using System;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Ivan.LojaTudoEletro.Domain.Entities;
using Ivan.LojaTudoEletro.Infra.Data.Contexto;

namespace Ivan.LojaTudoEletro.ProjetoModelo.MVC.Controllers
{
    public class UploadFileController : Controller
    {
        private ProjetoTudoEletroContexto db = new ProjetoTudoEletroContexto();

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

        public ActionResult Process(HttpPostedFileBase foto)
        {
            if (!isValidContentType(foto.ContentType))
            {
                ViewBag.Error = "Permitido somente os formatos: JPG, JPEG, PNG e GIF";
                return View("Succes");
            }
            else if(isValidContentLenght(foto.ContentLength))
            {
                ViewBag.Error = "O tamanho máximo permitido é de 8mb.";

                return View("Succes");
            }
            else
            {
                if (foto.ContentLength > 0)
                {
                    
                }
            }
           
        }


    }
}
