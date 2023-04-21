using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Ebis.Model;
using Ebis.Services;
using System;
using System.Collections.Generic;

namespace Ebis.ViewModel
{
    public class TechnicienViewModel
    {
        TechnicienService service;
        public ObservableCollection<Technicien> Techniciens { get; } = new();

        public TechnicienViewModel(TechnicienService service)
        {
            this.service = service;

            var techniciens = service.GetTechnicien();

            foreach (var technicien in techniciens)
            {
                Techniciens.Add(technicien);
            }
        }
    }
}