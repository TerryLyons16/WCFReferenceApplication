using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BusinessManagers.Factories;
using BusinessManagers.Interfaces;
using EntityFramework.Interfaces;
using EntityFramework.Entities;

namespace WCFLearningClient
{
    class Program
    {
        static void Main(string[] args)
        {

            IThreadManager m = ThreadManagerFactory.ThreadManager();
             m.CreateThread("Test Thread", null);

            //IForumUnitOfWork uow = ForumUOWFactory.ForumUnitOfWork();
            //uow.UserRepository.Create(new User { Username = "Service User" });
            //uow.SaveChanges();
            ////uow.PostRepository.Create(new Post { Content = "Hello!!" });
            ////uow.SaveChanges();

            //List<Post> posts = uow.PostRepository.All().ToList();

            //foreach(Post p in posts)
            //{
            //    Console.WriteLine(p.Content);
            //}


            //Console.ReadLine();


            //ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();

            //ShowPosts(client.GetPosts().ToList());

            //string input = Console.ReadLine();

            //while (input != "exit")
            //{

            ////    bool added =client.AddPost(input);

            //    if(added)
            //    {
            //        ShowPosts(client.GetPosts().ToList());
            //    }
            //    input = Console.ReadLine();
            //}
        }

        public static void ShowPosts(List<string> posts)
        {
            Console.Clear();

            foreach (string p in posts)
            {
                Console.WriteLine(p);
            }
        }
    }
}
