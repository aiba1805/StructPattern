using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentEditor
{
    public interface IGraphicDocument
    {
        void OptimalContrast();
        void OptimalBrightness();
        void SetFilter(Filter newFilter);
    }
}
