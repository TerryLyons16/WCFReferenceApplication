using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessManagers.Interfaces
{
    public interface IUserManager
    {
        bool Login(string username);
        bool AddUser(string username);
        List<string> GetUsers();
    }
}
