using Microsoft.EntityFrameworkCore;
using RegPrioridades.DAL;
using RegPrioridades.Models;

namespace RegPrioridades.BLL
{
    public class PrioridadesBLL
    {
        private readonly Contexto _contexto;
        private Prioridades _prioridades = new Prioridades();
        private string _mensaje = string.Empty;
        public PrioridadesBLL(Contexto contexto)
        {
            _contexto = contexto;
        }

        public Prioridades Prioridad
        {
            get { return _prioridades; }
            set { _prioridades = value; }
        }
        public string Mensaje
        {
            get { return _mensaje; }
            set { _mensaje = value; }
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
            _contexto.Prioridades.Remove(_contexto.Prioridades.Find(id));
            return _contexto.SaveChanges() > 0;
        }
        public List<Prioridades> getPrioridades()
        {
            return _contexto.Prioridades.ToList();
        }
    }
}
