using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class Auto : ITransport
    {
        public void Drive()
        {
            Console.WriteLine("Car drive");
        }
    }
}
