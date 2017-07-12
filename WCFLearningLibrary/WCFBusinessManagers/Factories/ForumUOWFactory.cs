using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EntityFramework;
using EntityFramework.Interfaces;

namespace BusinessManagers.Factories
{
    public static class ForumUOWFactory
    {

        public static IForumUnitOfWork ForumUnitOfWork()
        {
            return new ForumUnitOfWork();
        } 
    }
}
