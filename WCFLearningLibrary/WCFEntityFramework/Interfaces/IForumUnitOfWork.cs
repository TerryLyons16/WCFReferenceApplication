using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Repository.RepositoryInterfaces;

namespace EntityFramework.Interfaces
{
    public interface IForumUnitOfWork : IUnitOfWork
    {
        IPostRepository PostRepository { get; }
        IThreadRepository ThreadRepository { get; }
        IUserRepository UserRepository { get; }

    }
}
