using BuscaminasPortable.Models;
using BuscaminasPortable.PageModels;

namespace BuscaminasPortable.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageModel model)
        {
            InitializeComponent();
            BindingContext = model;
        }
    }
}