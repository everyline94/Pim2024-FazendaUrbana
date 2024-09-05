using Microsoft.AspNetCore.Mvc;
using Pim2024_FazendaUrbana.Models;

namespace Pim2024_FazendaUrbana.Controllers
{
    public class ProdutoController : Controller
    {
        private static List<Produto> produtos = new List<Produto>();

        // GET: Produto/Index
        public IActionResult Index()
        {
            return View(produtos);
        }

        // GET: Produto/Criar
        public IActionResult Criar()
        {
            return View();
        }

        // POST: Produto/Criar
        [HttpPost]
        public IActionResult Criar(Produto produto)
        {
            produtos.Add(produto);
            return RedirectToAction("Index");
        }

        // GET: Produto/Editar/1
        public IActionResult Editar(int id)
        {
            var produto = produtos.FirstOrDefault(p => p.Id == id);
            return View(produto);
        }

        // POST: Produto/Editar
        [HttpPost]
        public IActionResult Editar(Produto produto)
        {
            var existing = produtos.FirstOrDefault(p => p.Id == produto.Id);
            existing.Nome = produto.Nome;
            existing.Descricao = produto.Descricao;
            existing.Preco = produto.Preco;
            existing.Quantidade = produto.Quantidade;
            return RedirectToAction("Index");
        }

        // GET: Produto/Deletar/1
        public IActionResult Deletar(int id)
        {
            var produto = produtos.FirstOrDefault(p => p.Id == id);
            return View(produto);
        }

        // POST: Produto/Deletar
        [HttpPost, ActionName("Deletar")]
        public IActionResult ConfirmarDeletar(int id)
        {
            var produto = produtos.FirstOrDefault(p => p.Id == id);
            produtos.Remove(produto);
            return RedirectToAction("Index");
        }
    }
}

