using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentEditor
{
    public class GraphicDocument : Document,IDocument
    {
        public Filter DocumentFilter { get; set; }
    }
}
