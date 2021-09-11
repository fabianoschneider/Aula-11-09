using App.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Interfaces.Application
{
    public interface IPessoaService
    {
        Pessoa BuscaPorId(Guid id);
        
        List<Pessoa> ListaPessoas(string nome, int pesoMaiorQue, int pesoMenorQue);
        void Salvar(Pessoa obj);
        void Deletar(Guid id);

    }

}
