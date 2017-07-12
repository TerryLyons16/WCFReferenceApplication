using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Repository.RepositoryInterfaces;
using EntityFramework.Interfaces;
using EntityFramework.Repositories;

namespace EntityFramework
{
    public class ForumUnitOfWork : IForumUnitOfWork
    {

        //Unit of work acts as a factory for repositories

        protected ForumDBContext context;

        protected IPostRepository _postRepository;
        protected IUserRepository _userRepository;
        protected IThreadRepository _threadRepository; 


        public ForumUnitOfWork()
        {
            context = new ForumDBContext();
        }

        public void Dispose()
        {
            if (context != null)
                context.Dispose();


        }

        public IPostRepository PostRepository
        {
            get
            {
                if(_postRepository==null)
                {
                    _postRepository = new PostRepository(context);
                }
                return _postRepository;
            }
        }

        public IThreadRepository ThreadRepository
        {
            get
            {
                if (_threadRepository == null)
                {
                    _threadRepository = new ThreadRepository(context);
                }
                return _threadRepository;
            }
        }
        public IUserRepository UserRepository
        {
            get
            {
                if (_userRepository == null)
                {
                    _userRepository = new UserRepository(context);
                }
                return _userRepository;
            }
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }


    }
}
