using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AziendaPattern.Companies
{
    class Multi : ICompany
    {
        public string Name { get; set; }
        public Employee[] Employees { get; set; }

        public void AddEmployee(Employee empl)
        {
            for (int i = 0; i < Employees.Length; i++)
            {
                if (Employees[i] == null)
                {
                    Employees[i] = empl;
                    return;
                }

            }

        }

        public void CompanyMessage(string message)
        {
            Console.WriteLine($"Multinational company: {Name}" + message);
        }
    }
}
