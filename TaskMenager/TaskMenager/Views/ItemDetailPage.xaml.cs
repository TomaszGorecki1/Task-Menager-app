using System.ComponentModel;
using TaskMenager.ViewModels;
using Xamarin.Forms;

namespace TaskMenager.Views
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