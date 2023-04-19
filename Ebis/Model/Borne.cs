using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebis.Model
{
    public class Borne
    {
        public string idBorne { get; set; }
        public string date_mise_en_service { get; set; }
        public string date_derniere_revision { get; set; }
        public string date_fin_service { get; set; }
        public string fk_station { get; set; }
        public string fk_type_charge { get; set; }
    }
}
