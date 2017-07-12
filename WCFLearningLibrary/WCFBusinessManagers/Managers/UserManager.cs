using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessManagers.Interfaces;
using BusinessManagers.Factories;
using EntityFramework.Interfaces;
using EntityFramework.Entities;

namespace BusinessManagers.Managers
{
    internal class UserManager : IUserManager //With internal access, only the current assembly can access the class => other assemblies must use the factory
    {
        protected IForumUnitOfWork _uow;

        public UserManager()
        {
            _uow = ForumUOWFactory.ForumUnitOfWork();
        }

        public bool AddUser(string username)
        {
            _uow.UserRepository.Create(new User { Username = username, UserType = UserTypeEnum.User });
            _uow.SaveChanges();

            return true;
        }

        public List<string> GetUsers()
        {
            return _uow.UserRepository.All().Select(x => x.Username).ToList();
        }

        public bool Login(string username)
        {
            //Login successful if username exists
            return _uow.UserRepository.Contains(x => x.Username == username);

        }
    }
}
