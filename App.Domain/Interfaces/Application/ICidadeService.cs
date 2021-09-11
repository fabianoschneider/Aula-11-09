using App.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Interfaces.Application
{
    public interface ICidadeService
    {
        Cidade BuscaPorId(Guid id);
        Cidade BuscaPorCEP(string cep);
        List<Cidade> ListaCidades();
        void Salvar(Cidade obj);
        void Deletar(Guid id);
    }
}

