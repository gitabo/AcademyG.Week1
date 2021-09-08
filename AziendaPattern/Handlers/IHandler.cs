using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AziendaPattern.Handlers
{
    public interface IHandler
    {
        IHandler SetNext(IHandler handler);
        int HandleBonus(Employee employee, int Y, int W, int Z);
    }
}
