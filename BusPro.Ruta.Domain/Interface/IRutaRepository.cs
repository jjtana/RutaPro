using System.Collections.Generic;
using BusPro.Ruta.Domain.Entities;
using RutaPro.Common.Data.Repository;

namespace BusPro.Ruta.Domain.Interface
{
    public interface IRutaRepository : IBaseRepository<Domain.Entities.Ruta, int>
    {
        List<Ruta.Domain.Entities.Ruta> GetRutasById(int IdRuta);
    }
}