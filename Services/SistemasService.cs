using Microsoft.EntityFrameworkCore;
using RegPrioridades.DAL;
using RegPrioridades.Models;

namespace RegPrioridades.Services
{
    public class SistemasService
    {
        public readonly Contexto _contexto;

        public SistemasService(Contexto contexto)
        {
            _contexto = contexto;
        }

        public async Task<bool> Save(Sistemas sistema)
        {
            if(sistema.SistemaId ==0)
                _contexto.Sistemas.Add(sistema);
            else
                _contexto.Sistemas.Update(sistema);
            return await _contexto.SaveChangesAsync() > 0;
        }

        
        public async Task<bool> Delete(int id)
        {
            var sistema = await FindAsync(id);
            if(sistema == null)
                return false;
            _contexto.Sistemas.Remove(sistema);
            return await _contexto.SaveChangesAsync() > 0;
        }
        public async Task<Sistemas?> FindAsync(int id)
        {
            return await _contexto.Sistemas.FindAsync(id);
        }
        public async Task<List<Sistemas>> GetSistemas()
        {
            return await _contexto.Sistemas.ToListAsync();
        }
    }
}
