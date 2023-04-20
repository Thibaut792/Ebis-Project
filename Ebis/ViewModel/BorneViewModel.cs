using CommunityToolkit.Mvvm.Input;
using Ebis.Model;
using Ebis.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Ebis.ViewModel
{
   public partial class BorneViewModel
    {
        BorneService service;
        public ObservableCollection<Borne> Bornes { get; } = new();

        public BorneViewModel(BorneService service)
        {
            this.service = service;

            var bornes = service.GetBorne();

            foreach (var borne in bornes)
            {
                Bornes.Add(borne);
            }
        }
        [RelayCommand]
        async Task GoToDetailsBorne(Borne borne)
        {
            await Shell.Current.GoToAsync(
                "BornePage",
                true,
                new Dictionary<string, object>
                {
                {"Borne", borne}
                });
        }
    }
}
