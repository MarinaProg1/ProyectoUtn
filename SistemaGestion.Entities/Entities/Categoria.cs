using SistemaGestion.Entities.Interfaces;

namespace SistemaGestion.Entities.Entities
{
    public class Categoria : IEntity
    {
        public int Id { get; set; }
        public string NombreCategoria { get; set; }
        public Categoria()
        {
        }

        public override string ToString()
        {
            return $"{Id} - {NombreCategoria}";
        }

    }
}


