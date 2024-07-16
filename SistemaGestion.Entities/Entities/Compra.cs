using SistemaGestion.Entities.Interfaces;

namespace SistemaGestion.Entities.Entities
{
    public class Compra : IEntity
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public int ProductoId { get; set; }
        public int Cantidad { get; set; }
        public int UsuarioId { get; set; }
    }
}
