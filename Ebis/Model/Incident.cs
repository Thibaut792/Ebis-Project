using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebis.Model
{
    public class Incident
    {
        public Int32 idJournal_Incident { get; set; }
        public string details_incident { get; set; }
        public Int32 fk_type_incident { get; set; }

        public string libelle { get; set; }
    }
}
