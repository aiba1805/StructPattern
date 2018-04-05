using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class Driver
    {
        private ITransport transport;
        public Driver(ITransport transport)
        {
            this.transport = transport;
        }

        void Drive()
        {
            transport.Drive();
        }
    }
}
