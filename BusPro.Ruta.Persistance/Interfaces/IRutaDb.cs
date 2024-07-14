using BusPro.Ruta.Persistance.Models.Ruta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusPro.Ruta.Persistance.Interfaces
{
    public interface IRutaDB
    {
        void SaveRuta(RutaSaveModel rutaSave);
        void UpdateRuta(RutaUpdateModel updateModel);
        void RemoveRuta(RutaRemoveModel rutaRemove);
        List<RutaGetModel> GetRutas();
        RutaGetModel GetRuta(int IdRuta);
    }
}