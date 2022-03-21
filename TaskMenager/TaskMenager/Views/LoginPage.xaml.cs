using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskMenager.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TaskMenager.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            this.BindingContext = new LoginViewModel();
            var assembly = typeof(AboutPage).Assembly;
            iconImage.Source = ImageSource.FromResource("TaskMenager.Assets.Images.xamarin_logo.png", assembly);
        }
    }
}