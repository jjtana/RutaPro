using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusPro.Ruta.Persistance.Core
{
    public abstract class BaseEntity
    {
        protected BaseEntity()
        {
            this.FechaCreacion = DateTime.Now;
        }
        public DateTime FechaCreacion { get; set; }
    }
}
