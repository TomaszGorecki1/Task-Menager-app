using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskMenagerFinal.Helpers;
using Xamarin.Forms;

[assembly: Dependency(typeof(TaskMenagerFinal.Droid.Dependencies.Auth))]
namespace TaskMenagerFinal.Droid.Dependencies
{
    public class Auth : IAuth
    {
        public Auth()
        {
        }

        public string GetCurrentUserId()
        {
            throw new NotImplementedException();
        }

        public bool IsAuthenticated()
        {
            throw new NotImplementedException();
        }

        public async Task<bool> LoginUser(string email, string password)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> RegisterUser(string email, string password)
        {
            throw new NotImplementedException();
        }
    }
}