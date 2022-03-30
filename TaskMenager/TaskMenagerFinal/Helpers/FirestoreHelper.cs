using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TaskMenagerFinal.Model;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace TaskMenagerFinal.Helpers
{

    public interface IFirestore
    {
        Task<bool> Insert(Post post);
        Task<bool> Delete(Post post);
        Task<bool> Update(Post post);
        Task<List<Post>> Read();

    }

    public class Firestore
    {
        private static IFirestore firestore = DependencyService.Get<IFirestore>();

        public static async Task<bool> Insert(Post post)
        {
            return await firestore.Insert(post);
        }
        public static async Task<bool> Update(Post post)
        {
                return await firestore.Update(post);
        }
        public static async Task<bool> Delete(Post post)
        {
                return await firestore.Delete(post);
        }
        public static async Task<List<Post>> Read(Post post)
        {
            return await firestore.Read();
        }

    }
}
