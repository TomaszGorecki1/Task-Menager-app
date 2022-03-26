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
    public partial class PostDetalPage : ContentPage
    {

        Post selectedPost;

        public PostDetalPage(Post selectedPost)
        {
            InitializeComponent();

            this.selectedPost = selectedPost;
            experienceEntry.Text =selectedPost.Experience;
        }

        private void UpdateButton_Clicked(object sender, EventArgs e)
        {
            selectedPost.Experience = experienceEntry.Text;

            using (SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))
            {
                conn.CreateTable<Post>();
                int rows = conn.Update(selectedPost);

                if (rows > 0)
                {
                    DisplayAlert("succes", "Experience succesfully updated", "OK");
                }
                else
                {
                    DisplayAlert("failure", "Experience failed to be updated", "not ok");
                }
            }
        }

        private void DeleteButton_Clicked(object sender, EventArgs e)
        {
           

            using (SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))
            {
                conn.CreateTable<Post>();
                int rows = conn.Delete(selectedPost);

                if (rows > 0)
                {
                    DisplayAlert("succes", "Experience succesfully deleted", "OK");
                }
                else
                {
                    DisplayAlert("failure", "Experience failed to be deleted", "not ok");
                }
            }
        }
    }
}