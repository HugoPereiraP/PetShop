using PetShop.Helpers.Pagination;
using PetshopStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Domain.Interfaces
{
    public interface IDonoService
    {
        void Cadastrar(Dono dono);
        Dono? ValidarLogin(string email, string senha);
        Dono? BuscarPorId(int id);
        Dono? BuscarPorEmail(string email);

        
        List<Dono> ListarDonos();
       

        Task<PageResult<Dono>> ListarTodosPaginadoAsync(PageRequest pageRequest);
        Task<PageResult<Dono>> ListarPorNomePaginadoAsync(string nome, PageRequest pageRequest);
        Task<PageResult<Dono>> ListarPorCidadePaginadoAsync(int idCidade, PageRequest pageRequest);
        void Atualizar(Dono dono);
        void Remover(int id);
    }
}