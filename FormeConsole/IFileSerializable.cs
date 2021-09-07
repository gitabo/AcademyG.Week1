using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FormeConsole
{
    public interface IFileSerializable
    {
        public void SaveToFile(string nomefile);
        public void LoadFromFile(string nomefile);
    }
}
