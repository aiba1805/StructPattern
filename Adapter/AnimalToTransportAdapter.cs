using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class AnimalToTransportAdapter : ITransport
    {
        private IAnimal animal;
        public AnimalToTransportAdapter(IAnimal horse)
        {
            this.animal = horse;
        }

        void ITransport.Drive()
        {
            animal.Move();
        }

    }
}
