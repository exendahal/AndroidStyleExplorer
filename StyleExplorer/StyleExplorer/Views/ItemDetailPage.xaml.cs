using StyleExplorer.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace StyleExplorer.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}