using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusPro.Ruta.Persistance.Exceptions
{
    public class RutaException : Exception
    {
        public RutaException(string message) : base(message)
        {
        }
        public static void VerifyExistence(Domain.Entities.Ruta ruta, int idRuta)
        {
            if (ruta == null)
            {
                throw new RutaException($"La ruta con la id {idRuta} no está disponible.");
            }
        }

        internal static void VerifyExistence(Domain.Entities.Ruta? ruta, object?[]? idRuta)
        {
            throw new NotImplementedException();
        }
    }
}
