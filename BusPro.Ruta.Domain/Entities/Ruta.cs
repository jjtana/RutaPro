

using RutaPro.Common.Data.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusPro.Ruta.Domain.Entities
{
    public class Ruta : AuditEntity<int>
    {
        [Column("IdRuta")]
        public override int IdRuta { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public int ChangeUser { get; set; }
        public DateTime ChangeDate { get; set; }
    }
}
