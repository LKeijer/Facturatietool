using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturatie_tool
{
    public class Klant
    {
        public int ID { get; set; }
        public string voornaam { get; set; }
        public string achternaam { get; set; }
        public string straatnaam { get; set; }
        public int huisnummer { get; set; }
        public string plaats { get; set; }
        public string postcode { get; set; }
        public string telefoonnummer { get; set; }
        public string email { get; set; }
        public string rekeningnummer { get; set; }

    }
}
