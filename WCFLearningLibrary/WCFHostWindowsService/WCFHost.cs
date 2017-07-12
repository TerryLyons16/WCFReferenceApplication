using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Routing;

using WCFLearningLibrary;

namespace WCFHostWindowsService
{
    public partial class WCFHost : ServiceBase
    {
        public ServiceHost userServiceHost = null;
        public ServiceHost threadServiceHost = null;

        //Couldn't get client to correctly call the routing service due to SOAP mismatch issue
     //   public ServiceHost routingServiceHost = null;

        public WCFHost()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            //if (routingServiceHost != null)
            //{
            //    routingServiceHost.Close();
            //}

            //routingServiceHost = new ServiceHost(typeof(RoutingService));//Create a service host for the Routing Service
            //routingServiceHost.Open();



            if (userServiceHost != null)
            {
                userServiceHost.Close();
            }

            userServiceHost = new ServiceHost(typeof(UserService));//Create a service host for the WCF Service
            userServiceHost.Open();


            if (threadServiceHost != null)
            {
                threadServiceHost.Close();
            }

            threadServiceHost = new ServiceHost(typeof(ThreadService));//Create a service host for the WCF Service
            threadServiceHost.Open();

        }

        protected override void OnStop()
        {
            //if (routingServiceHost != null)
            //{
            //    routingServiceHost.Close();
            //    routingServiceHost = null;
            //}


            if (userServiceHost != null)
            {
                userServiceHost.Close();
                userServiceHost = null;
            }

            if (threadServiceHost != null)
            {
                threadServiceHost.Close();
                threadServiceHost = null;
            }

        }
    }
}
