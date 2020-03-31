using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MeusContatinhos.Dominio.Repositorio;
using MeusContatinhos.Dominio.Modelo;

namespace MeusContatinhos.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContatinhosController : ControllerBase // isto eh uma controller
    {
        ContatinhosRepositorio _repo;
        public ContatinhosController()
        {
            _repo = new ContatinhosRepositorio();
        }

        // GET: api/Contatinhos
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_repo.SelecionarTodos());
        }

        // GET: api/Contatinhos/5
        [HttpGet("ExisteEstaPessoa/{nome}")]
        public bool ExisteEstaPessoa(string nome)
        {
            return _repo.ExisteEstaPessoa(nome);
        }

        [HttpGet("SaoMaiores/{idade}")]
        public bool SaoMaiores(string idade)
        {
            return _repo.SaoMaioresDeIdade(idade);
        }

        [HttpGet("BuscarPorNome/{nome}")]
        public Contato Get(string nome)
        {
            return _repo.BuscarPorNome(nome);
        }

        [HttpGet("BuscarPorTel/{tel}")]
        public Contato GetTel(string tel)
        {
            return _repo.BuscarPorTel(tel);
        }

        // POST: api/Contatinhos
        [HttpPost]
        public List<Contato> Post([FromBody] Contato value)
        {            
            return _repo.Adicionar(value);
        }

        // PUT: api/Contatinhos/5
        [HttpPut("{id}")]
        public List<Contato> Put(int id, [FromBody] Contato value)
        {
            return _repo.Alterar(id, value);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public List<Contato> Delete(int id)
        {            
            return _repo.Excluir(id);
        }
    }
}
