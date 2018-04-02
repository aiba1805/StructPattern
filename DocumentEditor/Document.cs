using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentEditor
{
    public class Document : IDocument
    {
        public byte[] DocumentInBytes { get; set; }
        public Format DocumentFormat { get; set; }
        public Document()
        {
        }
        public void Close()
        {
            throw new NotImplementedException();
        }

        public void Create(string name)
        {
            throw new NotImplementedException();
        }

        public byte[] Open()
        {
            throw new NotImplementedException();
        }

        public void Print()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Save(string newName)
        {
            throw new NotImplementedException();
        }
    }
}
