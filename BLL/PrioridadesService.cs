using Microsoft.EntityFrameworkCore;
using RegPrioridades.DAL;
using RegPrioridades.Models;

namespace RegPrioridades.BLL
{
    public class PrioridadesService
    {
        private readonly Contexto _contexto;
        public PrioridadesService(Contexto contexto)
        {
            _contexto = contexto;
        }
        public async Task<bool> Existe(Prioridades prioridad)
        {
            bool existe = await _contexto.Prioridades.
                AnyAsync(p => p.Descripcion.ToLower() ==prioridad.Descripcion.ToLower());
            return existe;
        }
        public async Task<bool> Save(Prioridades prioridad)
        {
            if (await Existe(prioridad))
                return false;


            if (prioridad.PrioridadId ==0)
                _contexto.Prioridades.Add(prioridad);
            else
                _contexto.Update(prioridad);
             
            return await _contexto.SaveChangesAsync() > 0;
        }
        public async Task<Prioridades?> FindAsync(int id)
        {
            return await _contexto.Prioridades.FindAsync(id);
        }
        //public async Task<bool> Delete(int id)
        //{
        //    var prioridad = _contexto.Prioridades.Find(id);

        //    _contexto.Prioridades.Remove(prioridad!);
        //    var deleted = await _contexto.SaveChangesAsync() > 0;
        //    return deleted;
        //}
        public async Task<bool> Delete(int prioridad)
        {

            var eliminado = await _contexto.Prioridades.FindAsync(prioridad);
            if (eliminado == null)
            {
                return false;
            }
            else
            {
                _contexto.Prioridades.Remove(eliminado);
                return _contexto.SaveChanges() > 0;
            }

        }
        public async Task<List<Prioridades>> getPrioridades()
        {
            return await _contexto.Prioridades.ToListAsync();
        }
    }
}
