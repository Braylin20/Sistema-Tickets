using Microsoft.EntityFrameworkCore;
using RegPrioridades.DAL;
using RegPrioridades.Models;
using System.Linq.Expressions;

namespace RegPrioridades.BLL
{
    public class ClientesService
    {
        private readonly Contexto _contexto;

        public ClientesService(Contexto contexto)
        {
            _contexto = contexto;
        }

        public async Task<bool> Save(Clientes cliente)
        {
            if (await Existe(cliente))
                return false;
            if(cliente.ClienteId == 0)
                _contexto.Clientes.Add(cliente);
            else
                _contexto.Update(cliente);

            return await _contexto.SaveChangesAsync() >0;

        }

        public async Task<bool> Existe(Clientes cliente)
        {
            bool existe = await _contexto.Clientes.AnyAsync(c => 
            (c.Nombre!.ToLower() == cliente.Nombre!.ToLower() 
            || c.RNC == cliente.RNC));

            return existe;
        }

        public async Task<bool> Delete(int id)
        {
            var cliente = _contexto.Clientes.Find(id);

            _contexto.Clientes.Remove(cliente!);
            var deleted = await _contexto.SaveChangesAsync() > 0;
            return deleted;
        }

        public async Task<Clientes?> Buscar(int clienteId)
        {
            return await _contexto.Clientes
                .AsNoTracking()
                .FirstOrDefaultAsync(p => p.ClienteId== clienteId);
        }

        public async Task<List<Clientes>> Listar(Expression<Func<Clientes, bool>> criterio)
        {
            return await _contexto.Clientes
                .AsNoTracking()
                .Where(criterio)
                .ToListAsync();
        }

        public async Task<List<Clientes>> getClientes()
        {
            return await _contexto.Clientes.ToListAsync();
        }
    }
}
