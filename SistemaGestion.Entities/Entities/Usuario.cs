using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Threading.Tasks;
using SistemaGestion.Entities.Interfaces;
//Comentario de verificacion de cambios solo en la rama secundaria
namespace SistemaGestion.Entities.Entities
{/// <summary>
/// Definicion de clase y propiedades
/// </summary>
    public class Usuario : IEntity
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Hash { get; set; } // Representación del hash como string
        public string Salt { get; set; } // Representación del salt como string

    }
}
