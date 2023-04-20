using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ebis.Model;
using Ebis.Services;

namespace Ebis.ViewModel
{
    public class IncidentViewModel
    {
        IncidentService service;
        public ObservableCollection<Incident> Incidents { get; } = new();

        public IncidentViewModel(IncidentService service)
        {
            this.service = service;

            var incidents = service.GetIncident();

            foreach (var incident in incidents)
            {
                Incidents.Add(incident);
            }
        }
    }
}
