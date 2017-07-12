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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ThreadService" in both code and config file together.
    public class ThreadService : IThreadService
    {
        public bool CreateThread(string name, Guid? creatorID)
        {
            try
            {
                IThreadManager m = ThreadManagerFactory.ThreadManager();
                return m.CreateThread(name, creatorID);
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + "\n" + ex.StackTrace);
            }

        }

        public List<string> GetThreads()
        {
            try
            {
                IThreadManager m = ThreadManagerFactory.ThreadManager();
                return m.GetThreads();
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message + "\n" + ex.StackTrace);
            }
        }
    }
}
