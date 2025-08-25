using Fazeres___Saberes.Models;
using Microsoft.AspNetCore.Mvc;

namespace Fazeres___Saberes.Controllers
{
    public class InstituicaoController : Controller
    {
        private static IList<Instituicao> instituicoes = new List<Instituicao>
        {
            new Instituicao() {
                InstituicaoID = 1,
                Endereco = "UniSanta",
                Nome = "Universidade Santa Cecília"
            }
            , new Instituicao() {
                InstituicaoID = 2,
                Endereco = "São Paulo",
                Nome = "UniSãoPaulo"
            }
            , new Instituicao() {
                InstituicaoID = 3,
                Endereco = "Rio de Janeiro",
                Nome = "UniCarioca"
            }
            , new Instituicao() {
                InstituicaoID = 4,
                Endereco = "Unimes",
                Nome = "Universidade Metropolitana de Santos"
            },
            new Instituicao() {
                InstituicaoID = 5,
                Endereco = "Paraná",
                Nome = "UniParaná"
            }
        };
        [HttpGet]
        public IActionResult Index()
        {
            return View(instituicoes.OrderBy(i => i.InstituicaoID));
        }
        //GET
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Instituicao instituicao)
        {
            instituicoes.Add(instituicao);
            instituicao.InstituicaoID =
            instituicoes.Select(i => i.InstituicaoID).Max() + 1;
            return RedirectToAction("Index");
        }
        //GET
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var instituicao = instituicoes.FirstOrDefault(i => i.InstituicaoID == id);
            if (instituicao == null)
            {
                return NotFound();
            }
            return View(instituicao);
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Instituicao instituicao)
        {
            instituicoes[instituicoes.IndexOf(instituicoes.Where
                (i => i.InstituicaoID == instituicao.InstituicaoID).First())] = instituicao;
            return RedirectToAction("Index");
        }
    }
}
