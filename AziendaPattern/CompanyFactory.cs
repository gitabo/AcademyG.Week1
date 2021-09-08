using AziendaPattern.Companies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AziendaPattern
{
    class CompanyFactory
    {
        public int NumEmployees { get; set; }

        public CompanyFactory(int num)
        {
            NumEmployees = num;
        }

        public ICompany CreateCompany()
        {
            ICompany company = null;

            if (NumEmployees <= 20)
                company = new Small { Name = "SmallCompany" , Employees = new Employee[NumEmployees]};
            else if (NumEmployees <= 100)
                company = new Medium { Name = "MediumCompany" , Employees = new Employee[NumEmployees] };
            else if (NumEmployees <= 500)
                company = new Large { Name = "LargeCompany" , Employees = new Employee[NumEmployees] };
            else
                company = new Multi { Name = "Multinational company" , Employees = new Employee[NumEmployees] };

            return company;
        }
    }
}
