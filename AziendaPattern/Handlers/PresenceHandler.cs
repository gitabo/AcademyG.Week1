using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AziendaPattern.Handlers
{
    public class PresenceHandler : AbstractHandler
    {
        public override int HandleBonus(Employee employee, int Y, int W, int Z)
        {
            if (employee.eta < Y && employee.AbsencesRate < Z)
            {
                return 200;
            }
            return base.HandleBonus(employee, Y, W, Z);
        }
    }
}
