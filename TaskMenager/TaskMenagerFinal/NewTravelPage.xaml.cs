using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskMenagerFinal.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TaskMenagerFinal
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewTravelPage : ContentPage
    {
        public NewTravelPage()
        {
            InitializeComponent();
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            Post post = new Post();
            {
                 string Experience = experienceEntry.Text;
            };
            SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation);
            conn.CreateTable < Post >();
            int rows = conn.Insert(post);
            conn.Close();

            if(rows > 0)
            {
                DisplayAlert("succes", "Experience succesfully inserted", "OK");
            }   
            else
            {
                DisplayAlert("failure", "Experience failed to be inserted", "not ok");
            }
        }
    }
}