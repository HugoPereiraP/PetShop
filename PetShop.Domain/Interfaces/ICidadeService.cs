using PetshopStore.Domain.Entities;
using System.Collections.Generic;

namespace PetShop.Domain.Interfaces
{
    public interface ICidadeService
    {
        void Cadastrar(Cidade cidade);
        void Atualizar(Cidade cidade);
        void Excluir(int id);
        Cidade BuscarPorId(int id);
        IEnumerable<Cidade> Listar();
    }
}
