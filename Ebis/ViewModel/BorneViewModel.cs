using Ebis.Model;
using Ebis.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebis.ViewModel
{
   public partial class BorneViewModel
    {
        BorneService service;
        public ObservableCollection<Borne> Bornes { get; } = new();

        public BorneViewModel(BorneService service)
        {
            this.service = service;
        }
        async Task GetCentresDeDon()
        {
            var bornes = service.GetBorne(20);
            if (bornes.Count != 0)
                bornes.Clear();
            foreach (var borne in bornes)
            {
                Bornes.Add(borne);
            }
        }
    }
}
