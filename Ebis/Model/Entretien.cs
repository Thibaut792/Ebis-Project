using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebis.Model
{
    public class Entretien
    {
        public Int32 idBorne { get; set; }
        public string Adresse_Ville { get; set; }
        public string Adresse_Rue { get; set; }
        public string element_modifie { get; set; }
        public string nom { get; set; }
        public string fk_entretien_borne { get; set; }
    }
}
