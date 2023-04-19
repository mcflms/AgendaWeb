using AgendaWeb.Presentation.Models;
using Microsoft.AspNetCore.Mvc;

namespace AgendaWeb.Presentation.Controllers
{
    //teste branch junior
    public class AgendaController : Controller
    { public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost] //Annotation indica que o método será executado no SUBMIT
        public IActionResult Cadastro(EventoCadastroViewModel model)
        {
            return View();
        }

        public IActionResult Consulta()
        {
            return View();
        }

        public IActionResult Edicao()
        {
            return View();
        }

        public IActionResult Relatorio()
        {
            return View();
        }
    }
}
