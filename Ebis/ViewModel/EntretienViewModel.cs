using Ebis.Model;
using Ebis.Services;
using System.Collections.ObjectModel;


namespace Ebis.ViewModel
{
    public class EntretienViewModel
    {

        EntretienService service;
        public ObservableCollection<Entretien> Entretiens { get; } = new();

        public EntretienViewModel(EntretienService service)
        {
            this.service = service;

            var entretiens = service.GetEntretien();

            foreach (var entretien in entretiens)
            {
                Entretiens.Add(entretien);
            }
        }
    }
}
