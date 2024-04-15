using notes.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace notes.Views
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