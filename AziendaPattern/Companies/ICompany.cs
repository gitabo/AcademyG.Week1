using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AziendaPattern.Companies
{
    interface ICompany
    {
        public string Name { get; set; }
        public Employee[] Employees { get; set; }


        void CompanyMessage(string message);
        void AddEmployee(Employee empl);
    }
}
