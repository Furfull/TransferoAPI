using TransferoAPI.Models;
using TransferoAPI.Data;

namespace TransferoAPI.Services
{
    public class ClientesService : IClientesService
    {
        private readonly NoSQLDatabase<Clientes> _noSQLDataBase;

        public string container = "Clientes";

        public ClientesService()
        {
            _noSQLDataBase = new();
        }

        public async Task<IEnumerable<Clientes>> GetClientes()
        {
            return await _noSQLDataBase.GetAllItens(container);
        }

        public async Task<IEnumerable<Clientes>> GetClientesPorNome(string name)
        {
            return await _noSQLDataBase.GetByPredicate(container, m => m.Name == name);
        }

        public async Task AddClientes(Clientes cliente)
        {
            await _noSQLDataBase.Add(container, cliente, cliente.Id.ToString());
        }
    }
}
