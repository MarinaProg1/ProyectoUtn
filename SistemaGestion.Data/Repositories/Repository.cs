using SistemaGestion.Entities.Interfaces;

namespace SistemaGestion.Data.Repositories
{
    public class Repository<T> : IRepository<T> where T : class, IEntity
    {
        private readonly SistemaGestionContext _context;

        // Constructor.
        public Repository(SistemaGestionContext context)
        {
            _context = context;
        }
        
        // Métodos.
        public List<T> ObtenerTodosLosRegistros()
        {
            var registros = _context.Set<T>().ToList();
            return registros;
        }
        public T ObtenerPorId(int id)
        {
            var registro = _context.Set<T>().FirstOrDefault(r => r.Id == id);
            if (registro != null)
            {
                return registro;
            }else
            {
                throw new InvalidOperationException("No se correspondé con un Id cargado en el sistema.");
            }
        }
        public void InsertarRegistro(T registro)
        {
            _context.Add(registro);
            _context.SaveChanges();
        }
        public void EliminarRegistro(T registro)
        {
            _context.Remove(registro);
            _context.SaveChanges();
        }
        public void ActualizarRegistro(T registro)
        {
            _context.Update(registro);
            _context.SaveChanges();
        }
    }
}
