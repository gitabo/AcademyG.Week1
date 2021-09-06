using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormeConsole
{
    interface IFileSerializable
    {
        void SaveToFile(string messaggio);
        void LoadFromFile(string messaggio);
    }
}
