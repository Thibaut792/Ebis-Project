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
    public partial class infoBorneViewModel  : ObservableObject
    {
        [ObservableProperty]
        Borne borne;

        [ObservableProperty]
        Borne borneAfficher;

        InfoBorneService service;
        public ObservableCollection<Borne> Bornes { get; } = new();

        public infoBorneViewModel(InfoBorneService service)
        {
            this.service = service;

        }

        partial void OnBorneChanged(Borne value)
        {
            BorneAfficher = service.GetBorne(value.idBorne);
        }
    }
}
