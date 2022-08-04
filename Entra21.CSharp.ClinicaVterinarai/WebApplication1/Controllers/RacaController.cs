using Microsoft.AspNetCore.Mvc;

namespace Entra21.CSharp.ClinicaVeterinaria.Aplicacao.Controllers
{
    public class RacaController : Controller
    {
        /// <summary>
        /// EndPoint que permite listar toda as racas
        /// </summary>
        /// <returns></returns>Retorna a pagina html com as racas</returns>
        [Route("/raca")]
        [HttpGet]

        public IActionResult ObterTodos()
        {
            return View("Index");
        }
        [Route("/raca/Cadastrar")]
        [HttpGet]

        public IActionResult Cadastrar()
        {
            return View();
        }
        [Route("/raca/Registrar")]
        [HttpGet]

        public IActionResult Registrar(
            [FromQuery] string nome,
            [FromQuery] string especie)
        {
            return RedirectToAction("Index");
        }
    }
}
