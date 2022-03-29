using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskMenagerFinal.Helpers;
using Xamarin.Forms;

namespace TaskMenagerFinal
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var assembly = typeof(MainPage);
            iconImage.Source = ImageSource.FromResource("TaskMenagerFinal.Assets.Images.plane.png", assembly);

        }

        async void LoginButton_Clicked(object sender, EventArgs e)
        {

            bool isEmailEmpty=string.IsNullOrEmpty(emailEntry.Text);
            bool isPasswordEmpty=string.IsNullOrEmpty(passwordEntry.Text);

            if (isEmailEmpty || isPasswordEmpty)
            {
                //do not navigate
            }
            else
            {
                //authenticate
                bool result = await Auth.LoginUser(emailEntry.Text, passwordEntry.Text);
                // navigate
                if(result)
                   await Navigation.PushAsync(new HomePage());
            }
        }
    }
}
