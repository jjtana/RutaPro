using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using BusPro.Ruta.Domain.Entities;
using BusPro.Ruta.Domain.Interface;
using BusPro.Ruta.Persistance.Context;
using RutaPro.Common.Data.Repository;

namespace BusPro.Ruta.Infrastructure.Repositories
{
    public class RutaRepository : IBaseRepository<Domain.Entities.Ruta, int>
    {
        private readonly BoletoBusContext _context;

        public RutaRepository(BoletoBusContext context)
        {
            _context = context;
        }

        public void Save(Domain.Entities.Ruta entity)
        {
            _context.Ruta.Add(entity);
            _context.SaveChanges();
        }

        public void Update(Domain.Entities.Ruta entity)
        {
            var ruta = _context.Ruta.Find(entity.IdRuta);
            if (ruta != null)
            {
                ruta.Origen = entity.Origen;
                ruta.Destino = entity.Destino;
                ruta.ChangeUser = entity.ChangeUser;
                ruta.ChangeDate = entity.ChangeDate;
                _context.SaveChanges();
            }
        }

        public void Remove(Domain.Entities.Ruta entity)
        {
            var ruta = _context.Ruta.Find(entity.IdRuta);
            if (ruta != null)
            {
                _context.Ruta.Remove(ruta);
                _context.SaveChanges();
            }
        }

        public List<Domain.Entities.Ruta> GetAll()
        {
            return _context.Ruta.ToList();
        }

        public Domain.Entities.Ruta GetEntityBy(int id)
        {
            return _context.Ruta.Find(id);
        }

        public bool Exist(Expression<Func<Domain.Entities.Ruta, bool>> filter)
        {
            return _context.Ruta.Any(filter);
        }

        public List<Domain.Entities.Ruta> GetRutasById(int id)
        {
            
            return _context.Ruta.Where(r => r.IdRuta == id).ToList();
        }
    }
}