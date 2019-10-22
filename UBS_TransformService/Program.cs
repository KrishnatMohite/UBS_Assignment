using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topshelf;
using UBS_TransformService.Services;

namespace UBS_TransformService
{
    class Program
    {
        static void Main(string[] args)
        {
            HostFactory.Run(serviceConfig =>
            {
                serviceConfig.Service<TransformWindowsService>(serviceInstance =>
                {
                    serviceInstance.ConstructUsing(() => new TransformWindowsService());
                    serviceInstance.WhenStarted(execute => execute.Start());
                    serviceInstance.WhenStopped(execute => execute.Stop());
                });

                serviceConfig.SetServiceName("UBS Transform Service");
                serviceConfig.SetDisplayName("UBS Transform Service");
                serviceConfig.SetDescription("My UBS Transform Windows Service");

                serviceConfig.StartAutomatically();
            });

            //using (System.ServiceModel.ServiceHost host = new
            //    System.ServiceModel.ServiceHost(typeof(Services.CurrencyTransform)))
            //{
            //    host.Open();
            //    Console.WriteLine("Host started @ " + DateTime.Now.ToString());
            //    Console.ReadLine();
            //}
        }
    }
}
