using SistemaGestion.Entities.Interfaces;

namespace SistemaGestion.Entities.Entities
{
    public class Producto : IEntity
    {
        public int Id { get; set; }
        public int CategoriaId { get; set; }
        public string NombreProducto { get; set; }

        private bool _habilitado;

        public bool Habilitado
        {
            get { return _habilitado; }
        }

        public Producto()
        {
        }

        public override string ToString()
        {
            return $"Id: {Id}, Categoría: {CategoriaId}, Nombre: {NombreProducto}";
        }
    }
}


