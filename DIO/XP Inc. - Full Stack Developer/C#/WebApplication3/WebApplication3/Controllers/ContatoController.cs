using Microsoft.AspNetCore.Mvc;
using WebApplication3.Context;
using WebApplication3.Entites;
using System.Linq;

namespace WebApplication3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContatoController : ControllerBase
    {
        private readonly AgendaContext _context;
        public ContatoController(AgendaContext context) 
        { 
            _context = context;
        }
        [HttpPost]
        public IActionResult Create(Contato contato)
        {
            _context.Add(contato);
            _context.SaveChanges();
            return Ok(contato);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            
            var contato = _context.Contatos.Find(id);

            if (contato == null)
            {
                return NotFound();
            }
            return Ok(contato);
        }
        [HttpGet("GetByName")]
        public IActionResult GetByName(string name)
        {
            var contatos = _context.Contatos.Where(c => c.Nome.Contains(name));
            return Ok(contatos);
        }


        [HttpPut("{id}")]
        public IActionResult UpdateContact(int id, Contato contato)
        {

            var contatoAtualizado = _context.Contatos.Find(id);

            if (contato == null)
            {
                return NotFound();
            }

            contatoAtualizado.Nome = contato.Nome;
            contatoAtualizado.Telefone = contato.Telefone;
            contatoAtualizado.Ativo = contato.Ativo;
            
            _context.Contatos.Update(contatoAtualizado);
            _context.SaveChanges();
            
            return Ok(contatoAtualizado);
        }

        [HttpDelete("{id}")]

        public IActionResult Delete(int id)
        {
            var contato = _context.Contatos.Find(id);

            if (contato == null)
            {
                return NotFound();
            }

            _context.Contatos.Remove(contato);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
