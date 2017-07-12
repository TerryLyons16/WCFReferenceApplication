using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessManagers.Interfaces
{
    public interface IThreadManager
    {
        bool CreateThread(string threadName, Guid? creatorID);
        List<string> GetThreads();
    }
}
