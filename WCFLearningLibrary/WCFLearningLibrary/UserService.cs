using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BusinessManagers.Factories;

using BusinessManagers.Interfaces;

namespace WCFLearningLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class UserService : IUserService
    {
        public bool Login(string username)
        {
            try
            {
                IUserManager m = UserManagerFactory.UserManager();
                return m.Login(username);
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + "\n" + ex.StackTrace);
            }
        }

        public bool AddUser(string username)
        {
            try
            {
                IUserManager m = UserManagerFactory.UserManager();
                return m.AddUser(username);
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message +"\n"+ex.StackTrace);
            }
        }

        public List<string> GetUsers()
        {
            try
            {
                IUserManager m = UserManagerFactory.UserManager();
                return m.GetUsers();
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + "\n" + ex.StackTrace);
            }
        }

     
    }
}
