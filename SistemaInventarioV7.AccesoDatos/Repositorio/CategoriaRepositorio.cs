using SistemaInventarioV7.AccesoDatos.Data;
using SistemaInventarioV7.AccesoDatos.Repositorio.IRepositorio;
using SistemaInventarioV7.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventarioV7.AccesoDatos.Repositorio
{
    public class CategoriaRepositorio : Repositorio<Categoria>, ICategoriaRepositorio
    {
        private readonly ApplicationDbContext _db;

        public CategoriaRepositorio(ApplicationDbContext db) : base(db)
        {
              this._db = db;
        }
        public void Actualizar(Categoria categoria)
        {
            var categoriaEntity = _db.Categorias.FirstOrDefault(b => b.Id == categoria.Id);
            if (categoriaEntity != null)
            {
                categoriaEntity.Nombre = categoria.Nombre;
                categoriaEntity.Descripcion = categoria.Descripcion;
                categoriaEntity.Estado = categoria.Estado;
                _db.SaveChanges();
            }
        }
    }
}
