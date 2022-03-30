using Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;
using TaskMenagerFinal.Helpers;
using Xamarin.Forms;
using TaskMenagerFinal.Model;
using System.Threading.Tasks;

[assembly: Dependency(typeof(TaskMenagerFinal.iOS.Dependencies.Firestore))]
namespace TaskMenagerFinal.iOS.Dependencies
{
    public class Firestore : IFirestore
    {
        public Firestore()
        {
        }

        public Task<bool> Delete(Post post)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Insert(Post post)
        {
            throw new NotImplementedException();
        }

        public Task<List<Post>> Read()
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(Post post)
        {
            throw new NotImplementedException();
        }
    }
}