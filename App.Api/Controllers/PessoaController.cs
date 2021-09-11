using App.Domain.Entities;
using App.Domain.Interfaces.Application;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PessoaController : Controller
    {
        private IPessoaService _service;

        public PessoaController(IPessoaService service)
        {
            _service = service;
        }

        [HttpGet("ListaPessoas")]

        public JsonResult ListaPessoas(string nome, int pesoMaiorQue, int pesoMenorQue)
        {
            
            return Json(_service.ListaPessoas(nome,pesoMaiorQue,pesoMenorQue));
        }

        [HttpGet("BuscaPorId")]

        public JsonResult BuscaPorId(Guid id)
        {
            return Json(_service.BuscaPorId(id)); 
        }
        [HttpPost("Salvar")]

        public JsonResult Salvar(String nome, int peso, DateTime dataNascimento, bool ativo, Guid cidadeId)
        {
            var obj = new Pessoa
            {
                Nome = nome,
                DataNascimento = dataNascimento,
                Peso = peso,
                Ativo = ativo,
                CidadeId = cidadeId
            };
            _service.Salvar(obj);
            return Json(true);
        }
        
        [HttpDelete("Deletar")]
        public JsonResult Deletar(Guid id)
        {
            
            _service.Deletar(id);
            return Json(true);
        }
    }
}
