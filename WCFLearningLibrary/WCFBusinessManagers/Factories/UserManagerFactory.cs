using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessManagers.Interfaces;
using BusinessManagers.Managers;

namespace BusinessManagers.Factories
{
    public static class UserManagerFactory
    {

        public static IUserManager UserManager()
        {
            return new UserManager();
        }
    }
}
