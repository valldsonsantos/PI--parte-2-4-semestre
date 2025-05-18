using Microsoft.AspNetCore.Mvc;
using TarefasAPI.Data;
using TarefasAPI.Models;

namespace TarefasAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TarefaController : ControllerBase
    {
        private readonly AppDbContext _context;

        public TarefaController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Tarefa>> Get()
        {
            return Ok(_context.Tarefas.ToList());
        }

        [HttpPost]
        public ActionResult<Tarefa> Post(Tarefa tarefa)
        {
            _context.Tarefas.Add(tarefa);
            _context.SaveChanges();
            return CreatedAtAction(nameof(Get), new { id = tarefa.Id }, tarefa);
        }
    }
}