using App.Domain.Entities;
using App.Domain.Interfaces.Application;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CidadeController : Controller
    {
        private ICidadeService _service;

        public CidadeController(ICidadeService service)
        {
            _service = service;
        }

        [HttpGet("ListaCidades")]

        public JsonResult ListaCidades()
        {
            return Json(_service.ListaCidades());
        }

        [HttpGet("BuscaPorId")]

        public JsonResult BuscaPorId(Guid id)
        {
            return Json(_service.BuscaPorId(id));
        }

        [HttpGet("BuscaPorCEP")]

        public JsonResult BuscaPorCEP(string cep)
        {
            return Json(_service.BuscaPorCEP(cep));
        }
        [HttpPost("Salvar")]

        public JsonResult Salvar(String cep, String nome, String uf)
        {
            var obj = new Cidade
            {
                Cep = cep,
                Nome = nome,
                UF = uf

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
