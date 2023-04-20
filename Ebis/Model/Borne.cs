using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebis.Model
{
    public class Borne
    {
        public Int32 idBorne { get; set; }
        public DateTime date_mise_en_service { get; set; }
        public DateTime date_derniere_revision { get; set; }
        public DateTime date_fin_service { get; set; }
        public string Adresse_Ville { get; set; }
        public string Adresse_Rue { get; set; }
        public Int32 Code_Postal { get; set; }
        public string fk_station { get; set; }
        public string fk_type_charge { get; set; }
        public string libelle_type_charge { get; set; }


    }
}
