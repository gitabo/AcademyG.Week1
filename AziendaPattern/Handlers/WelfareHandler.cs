using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AziendaPattern.Handlers
{
    public class WelfareHandler : AbstractHandler
    {
        public override int HandleBonus(Employee employee, int Y, int W, int Z)
        {
            if (employee.ProductivityRate > W)
            {
                return 400;
            }
            return base.HandleBonus(employee, Y, W, Z);
        }
    }
}
