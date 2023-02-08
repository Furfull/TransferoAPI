using TransferoAPI.Models;

namespace TransferoAPI.Services
{
    public interface IClientesService
    {
        Task<IEnumerable<Clientes>> GetClientes();
        Task<IEnumerable<Clientes>> GetClientesPorNome(string name);
        Task AddClientes(Clientes cliente);

    }
}
