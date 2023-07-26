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
    public class BodegaRepositorio : Repositorio<Bodega>, IBodegaRepositorio
    {
        private readonly ApplicationDbContext _db;

        public BodegaRepositorio(ApplicationDbContext db) : base(db)
        {
              this._db = db;
        }
        public void Actualizar(Bodega bodega)
        {
            var bodegaEntity = _db.Bodegas.FirstOrDefault(b => b.Id == bodega.Id);
            if (bodegaEntity != null)
            {
                bodegaEntity.Nombre = bodega.Nombre;
                bodegaEntity.Descripcion = bodega.Descripcion;
                bodegaEntity.Estado = bodega.Estado;
                _db.SaveChanges();
            }
        }
    }
}
