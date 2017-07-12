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
    internal class ThreadManager : IThreadManager
    {
        protected IForumUnitOfWork _uow;

        public ThreadManager()
        {
            _uow = ForumUOWFactory.ForumUnitOfWork();
        }

        public bool CreateThread(string threadName, Guid? creatorID)
        {
            _uow.ThreadRepository.Create(new Thread { Title = threadName, CreatorId = creatorID });
            _uow.SaveChanges();


            return true;
        }

        public List<string> GetThreads()
        {
            return _uow.ThreadRepository.All().Select(x => x.Title).ToList();
        }
    }
}
