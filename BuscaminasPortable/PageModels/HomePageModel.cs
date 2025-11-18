using CommunityToolkit.Mvvm.ComponentModel;

namespace BuscaminasPortable.PageModels
{
    public partial class HomePageModel : ObservableObject
    {
        [ObservableProperty]
        private string _title = "Inicio";
    }
}
