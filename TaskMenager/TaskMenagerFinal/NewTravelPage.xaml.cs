using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskMenagerFinal.Helpers;
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
            try
            {
               

                Post newPost = new Post()
                {
                    Experience = experienceEntry.Text,
                };

                //using (SQLiteConnection conn = new SQLiteConnection(App.databaseLocation))
                //{
                //    conn.CreateTable<Post>();
                //    int rowsAffected = conn.Insert(newPost);

                //    if (rowsAffected > 0)
                //    {
                //        experienceEntry.Text = string.Empty;
                //        DisplayAlert("Success", "Post saved", "Ok");
                //    }
                //    else
                //        DisplayAlert("Failure", "Post was not saved, please try again", "Ok");
                //}

                bool result = Firestore.Insert(newPost);
                if (result)
                {
                    experienceEntry.Text = string.Empty;
                    DisplayAlert("Success", "Post saved", "Ok");
                }
                else
                    DisplayAlert("Failure", "Post was not saved, please try again", "Ok");
            }
            catch (NullReferenceException nrex)
            {

            }
            catch(Exception ex)
            {

            }
        }
    }
}