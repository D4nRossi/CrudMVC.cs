using Microsoft.AspNetCore.Mvc;

namespace CrudMVC.Controllers {
    public class ContatoController : Controller {
        //Página index da controller
        public IActionResult Index() {
            return View();
        }

        public IActionResult Criar() {
            return View();
        }

        public IActionResult Editar() {
            return View();
        }

        public IActionResult DeletarConfirmacao() {
            return View();
        }
    }
}
