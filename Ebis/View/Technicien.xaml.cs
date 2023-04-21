using Ebis.ViewModel;

namespace Ebis.View;

public partial class Technicien : ContentPage
{
    public Technicien(TechnicienViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}