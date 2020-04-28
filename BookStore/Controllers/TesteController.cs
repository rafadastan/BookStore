using BookStore.Domain;
using System.Web.Mvc;

namespace BookStore.Controllers
{
    public class TesteController : Controller
    {
        public ViewResult Dados(int id)
        {
            var autor = new Autor
            {
                Id = 1,
                Nome = "Raphael Augusto"
            };
            //12:36 4.Trafegando informações Balta.IO
            ViewBag.Categoria = "Produto de limpeza";
            ViewData["Categoria"] = "Produto de Informática";
            TempData["Categoria"] = "Produto de escritorio";
            Session["Categoria"] = "Moveis";

            return View(autor);
        }

        public string Index(int id)
        {
            return "Index do " +id.ToString();
        }

        public JsonResult UmaAction(int id, string nome)
        {
            var autor = new Autor
            {
                Id = id,
                Nome = nome
            };

            return Json(autor, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        [ActionName("autor")]
        public JsonResult ActionDois(Autor autor)
        {
            return Json(autor);
        }

        [Route("minharota/{id}")]
        public string MinhaAction(int id)
        {
            return "Ok! Cheguei na rota!";
        }

    }
}