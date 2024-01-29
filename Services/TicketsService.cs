using Microsoft.EntityFrameworkCore;
using RegPrioridades.DAL;
using RegPrioridades.Models;

namespace RegPrioridades.Services
{
    public class TicketsService
    {
        public readonly Contexto _contexto;
        public TicketsService(Contexto contexto)
        {
            _contexto = contexto;
        }

        public async Task<bool> Save(Tickets ticket)
        {
            if(ticket.TicketId == 0)
                await _contexto.Tickets.AddAsync(ticket);
            else
                _contexto.Update(ticket);

            return await _contexto.SaveChangesAsync() > 0;
        }

        public async Task<bool> Delete(int ticket)
        {
            var eliminado = await _contexto.Tickets.FindAsync(ticket);
            if (eliminado == null)
            {
                return false;
            }
            else
            {
                _contexto.Tickets.Remove(eliminado);
                return _contexto.SaveChanges() > 0;
            }
        }
        public async Task<Tickets?> FindAsync(int id)
        {
            return await _contexto.Tickets.FindAsync(id);
        }
        public async Task<List<Tickets>> GetTickets()
        {
            return await _contexto.Tickets.ToListAsync();
        }
        public async Task<Tickets?> Buscar(int ticketId)
        {
            return await _contexto.Tickets
                .AsNoTracking()
                .FirstOrDefaultAsync(t => t.TicketId== ticketId);
        }
    }
}
