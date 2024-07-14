namespace BusPro.Ruta.Persistance.Models.Ruta
{
    public class RutaGetModel
    {
        public int IdRuta { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public string ChangeUser { get; set; }
        public DateTime ChangeDate { get; set; }
    }
}