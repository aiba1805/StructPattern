using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class Horse : IAnimal
    {
        public void Move()
        {
            Console.WriteLine("Horse moves");
        }
    }
}
