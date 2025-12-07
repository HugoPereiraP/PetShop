using PetShop.Helpers.Pagination;
using PetshopStore.Domain.Entities;

public interface IAgendamentoService
{
    void Cadastrar(Agendamento agendamento);
    void Atualizar(Agendamento agendamento);
    void Remover(int id);
    Agendamento? BuscarPorId(int id);
    List<Agendamento> ListarAgendamentos();
    Task<PageResult<Agendamento>> ListarTodosPaginadoAsync(PageRequest pageRequest);
    Task<PageResult<Agendamento>> ListarPorPetPaginadoAsync(int idPet, PageRequest pageRequest);
    Task<PageResult<Agendamento>> ListarPorServicoPaginadoAsync(int idServico, PageRequest pageRequest);
}

