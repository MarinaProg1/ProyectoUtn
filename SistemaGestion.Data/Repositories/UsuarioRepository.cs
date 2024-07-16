using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestion.Entities.Entities;
using SistemaGestion.Entities.Interfaces;

namespace SistemaGestion.Data.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly SistemaGestionContext _context;

        public UsuarioRepository(SistemaGestionContext context)
        {
            _context = context;
        }

        public void insertarUsuario(Usuario usuario)
        {
            _context.Usuario.Add(usuario);
            _context.SaveChanges();
        }

        public void EliminarUsuario(int id)
        {
            var usuario = _context.Usuario.ToList().Find(p => p.Id == id);
            _context.Remove(usuario);
            _context.SaveChanges();


        }

        public async Task<Usuario> ObtenerUsuarioPorNombre(string nombreUsuario)
        {
            return await _context.Usuario.FirstOrDefaultAsync(u => u.Nombre == nombreUsuario);
        }

        public bool ExisteUsuario(string nombreUsuario)
        {
            string nombreLower = nombreUsuario.Trim().ToLower();
            return _context.Usuario.Any(p => p.Nombre.ToLower() == nombreLower);
           
        }

    }
}
