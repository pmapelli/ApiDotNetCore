using ApiUsuarios.Models;
using System.Collections.Generic;

namespace ApiUsuarios.Repositorio
{
    interface IUsuarioRepository
    {
        void Add(Usuario user);
        IEnumerable<Usuario> GetAll();
        Usuario Find(long id);
        void Remove(long id);
        void Update(Usuario user);
    }
}