using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AziendaPattern.Handlers
{

    public abstract class AbstractHandler : IHandler
        {
           

            private IHandler _nextHandler;

            public virtual int HandleBonus(Employee employee, int Y, int W, int Z)
            {
                if (_nextHandler != null)
                {
                    return _nextHandler.HandleBonus(employee, Y, W, Z);
                }
                return 0;
            }

            public IHandler SetNext(IHandler handler)
            {
                _nextHandler = handler;
                return _nextHandler;
            }
        }
    
}
