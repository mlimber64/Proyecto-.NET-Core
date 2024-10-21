using PruebaTecnica.Domain.Entities;
using PruebaTecnica.Domain.Service;

namespace PruebaTecnica.Application.ServiceImpl
{
    public class ClienteServiceImpl : IClienteService
    {
        

        public Task<bool> ActualizarClienteAsync(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public Task<Cliente> CrearClienteAsync(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public Task<bool> EliminarClienteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Cliente> GetClienteByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Cliente>> GetClientesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
