using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFLearningConsoleClient
{
    public class Program
    {
        public static void Main(string[] args)
        {
            UserService.UserServiceClient client = new UserService.UserServiceClient();

            Console.WriteLine("Create User - Enter Username:");

            string user = Console.ReadLine();

            while(user!="exit")
            {
                bool added = client.AddUser(user);

                Console.WriteLine("Added: " + added);

                user = Console.ReadLine();
            }


            client.Close();
        }
    }
}
