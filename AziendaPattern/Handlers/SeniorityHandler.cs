using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AziendaPattern.Handlers
{
    public class SeniorityHandler : AbstractHandler
    {
        public override int HandleBonus(Employee employee, int Y, int W, int Z)
        {
            if (employee.anzianita > 43)
            {
                return 300;
            }
            return base.HandleBonus(employee, Y, W, Z);
        }
    }
}
