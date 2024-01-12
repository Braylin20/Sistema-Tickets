using Microsoft.EntityFrameworkCore;
using RegPrioridades.DAL;
using RegPrioridades.Models;

namespace RegPrioridades.BLL
{
    public class PrioridadesBLL
    {
        private readonly Contexto _contexto;
        public PrioridadesBLL(Contexto contexto)
        {
            _contexto = contexto;
        }
        public bool Validar(Prioridades prioridades)
        {
            bool existe = _contexto.Prioridades.Any(p => p.Descripción.ToLower() == prioridades.Descripción.ToLower());
            return existe;
        }
        public bool Save(Prioridades prioridades)
        {
            if(Validar(prioridades))
            {
                return false;
            }
            if (prioridades.PrioridadId == 0)
                _contexto.Prioridades.Add(prioridades);
            else
                _contexto.Entry(prioridades).State = EntityState.Modified;
            var saved = _contexto.SaveChanges() > 0;
            return saved;
        }
        public async Task<Prioridades?> FindAsync(int id)
        {
            return await _contexto.Prioridades.FindAsync(id);
        }
        public bool Delete(int id)
        {
            var prioridad = _contexto.Prioridades.Find(id);
            _contexto.Prioridades.Remove(prioridad);
            return _contexto.SaveChanges() > 0;
        }
        public List<Prioridades> getPrioridades()
        {
            return _contexto.Prioridades.ToList();
        }
    }
}
