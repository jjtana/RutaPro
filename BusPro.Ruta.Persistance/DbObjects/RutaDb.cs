using BusPro.Ruta.Persistance.Context;
using BusPro.Ruta.Persistance.Interfaces;
using BusPro.Ruta.Persistance.Models.Ruta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusPro.Ruta.Persistance.DbObjects
{
    public class RutaDB : IRutaDB
    {
        private readonly BoletoBusContext _context;

        public RutaDB(BoletoBusContext context)
        {
            _context = context;
        }

        public void SaveRuta(RutaSaveModel rutaSave)
        {
            var ruta = new Domain.Entities.Ruta
            {
                Origen = rutaSave.Origen,
                Destino = rutaSave.Destino,
                ChangeUser = rutaSave.ChangeUser,
                ChangeDate = rutaSave.ChangeDate
            };
            _context.Ruta.Add(ruta);
            _context.SaveChanges();
        }

        public void UpdateRuta(RutaUpdateModel updateModel)
        {
            var ruta = _context.Ruta.Find(updateModel.IdRuta);
            if (ruta != null)
            {
                ruta.Origen = updateModel.Origen;
                ruta.Destino = updateModel.Destino;
                ruta.ChangeUser = updateModel.ChangeUser;
                ruta.ChangeDate = updateModel.ChangeDate;
                _context.SaveChanges();
            }
        }

        public void RemoveRuta(RutaRemoveModel rutaRemove)
        {
            var ruta = _context.Ruta.Find(rutaRemove.IdRuta);
            if (ruta != null)
            {
                _context.Ruta.Remove(ruta);
                _context.SaveChanges();
            }
        }

        public List<RutaGetModel> GetRutas()
        {
            return _context.Ruta.Select(r => new RutaGetModel
            {
                IdRuta = r.IdRuta,
                Origen = r.Origen,
                Destino = r.Destino,
                ChangeUser = r.ChangeUser,
                ChangeDate = r.ChangeDate
            }).ToList();
        }

        public RutaGetModel GetRuta(int IdRuta)
        {
            var ruta = _context.Ruta.Find(IdRuta);
            if (ruta != null)
            {
                return new RutaGetModel
                {
                    IdRuta = ruta.IdRuta,
                    Origen = ruta.Origen,
                    Destino = ruta.Destino,
                    ChangeUser = ruta.ChangeUser,
                    ChangeDate = ruta.ChangeDate
                };
            }
            return null;
        }
    }
}