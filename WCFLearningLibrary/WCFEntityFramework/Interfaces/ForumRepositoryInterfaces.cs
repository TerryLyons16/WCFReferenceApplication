using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Repository.RepositoryInterfaces;
using EntityFramework.Entities;

namespace EntityFramework.Interfaces
{
    public interface IPostRepository : IRepository<Post>
    {
        //Add methods unique to this repository here
    }

    public interface IThreadRepository : IRepository<Thread>
    {
        //Add methods unique to this repository here
    }

    public interface IUserRepository : IRepository<User>
    {
        //Add methods unique to this repository here
    }
}
