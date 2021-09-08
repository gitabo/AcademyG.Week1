using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AziendaPattern.Handlers
{
    public class ProductivityHandler : AbstractHandler
    {
        public override int HandleBonus(Employee employee, int Y, int W, int Z)
        {
            if (employee.eta < Y && employee.ProductivityRate > W)
            {
                return 100;
            }
            return base.HandleBonus(employee, Y, W, Z);
        }
    }
}
