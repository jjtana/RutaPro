using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusPro.Ruta.Persistance.Models.Ruta
{
    public abstract class RutaBaseModel : ModelBase

    {
        [Key] public int IdRuta { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
    }
}
