﻿using System.Linq;
using ApiUsuarios.Models;
using System.Collections.Generic;

namespace ApiUsuarios.Repositorio
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public UsuarioDbContext _contexto { get; set; }

        public UsuarioRepository(UsuarioDbContext ctx)
        {
            _contexto = ctx;
        }

        public void Add(Usuario usuario)
        {
            _contexto.Usuarios.Add(usuario);
            _contexto.SaveChanges();
        }

        public Usuario Find(long id)
        {
            return _contexto.Usuarios.FirstOrDefault(u => u.UsuarioId == id);
        }

        public IEnumerable<Usuario> GetAll()
        {
            return _contexto.Usuarios.ToList();
        }

        public void Remove(long id)
        {
            var entity = _contexto.Usuarios.First(u => u.UsuarioId == id);
            _contexto.Usuarios.Remove(entity);
            _contexto.SaveChanges();
        }

        public void Update(Usuario usuario)
        {
            _contexto.Usuarios.Update(usuario);
            _contexto.SaveChanges();
        }
    }
}