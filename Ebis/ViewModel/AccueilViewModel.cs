using CommunityToolkit.Mvvm.Input;
using Ebis.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebis.ViewModel
{
   public partial class AccueilViewModel
    {
        [RelayCommand]
        async Task GoToBornePage()
        {
            await Shell.Current.GoToAsync(
                nameof(BornePage),
                true
               );
        }
    }
}
