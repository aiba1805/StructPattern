using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentEditor
{
    public interface IDocument
    {
        void Save();
        void Save(string newName);
        byte[] Open();
        void Create(string name);
        void Print();
        void Close();
    }
}
