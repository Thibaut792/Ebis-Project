using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Ebis.Model;
using Ebis.Services;


namespace Ebis.ViewModel
{
    [QueryProperty("Borne", "Borne")]
    public partial class infoBorneViewModel 
    {
        //[ObservableProperty]
        //Borne borne;

        InfoBorneService service;
        public ObservableCollection<Borne> Bornes { get; } = new();

        public infoBorneViewModel(InfoBorneService service)
        {
            this.service = service;

            var bornes = service.GetBorne();

            foreach (var borne in bornes)
            {
                Bornes.Add(borne);
            }
        }
    }
}
