using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BusinessManagers.Interfaces;
using BusinessManagers.Managers;

namespace BusinessManagers.Factories
{
    public static class ThreadManagerFactory
    {
        public static IThreadManager ThreadManager()
        {
            return new ThreadManager();
        }

    }
}
