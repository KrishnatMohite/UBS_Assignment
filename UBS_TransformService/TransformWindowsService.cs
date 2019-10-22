using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace UBS_TransformService
{
    public class TransformWindowsService
    {
        private ServiceHost _luhtWcfServiceHost;
        public void Start()
        {
            // write code here that runs when the Windows Service starts up.
            try
            {
                _luhtWcfServiceHost = new ServiceHost(typeof(Services.CurrencyTransform));
                _luhtWcfServiceHost.Open();
                //Console.WriteLine("Service Running...");
                //Console.WriteLine("Press a key to quit");
            }
            catch
            {
            }
        }
        public void Stop()
        {
            // write code here that runs when the Windows Service stops.
            _luhtWcfServiceHost.Close();
        }
    }
}
