using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RutaPro.Common.Data.Base
{
    public abstract class AuditEntity<TType> : BaseEntity<TType>
    {

        public string? Origen { get; set; }
        public string? Destino { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime ChangeDate {  get; set; }
        public DateTime ChangeUser {  get; set; }
       
    }
}
