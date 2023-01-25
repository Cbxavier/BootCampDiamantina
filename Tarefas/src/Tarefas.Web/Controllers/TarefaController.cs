using Microsoft.AspNetCore.Mvc;
using Tarefas.Web.Models;

namespace Tarefas.Web.Controllers
{
    public class TarefaController: Controller 
    {
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Index()
        {
            var listaDeTarefas = new List<TarefaViewModel>() 
            {
                new TarefaViewModel(){Titulo = "Escovar os dentes"},
                new TarefaViewModel(){Titulo = "Arrumar a cama"},
                new TarefaViewModel(){Titulo = "Por o lixo para fora", Descricao="Somente as tercas"}
            };
            return View(listaDeTarefas);
        }
        
    }
}