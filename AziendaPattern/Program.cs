using AziendaPattern.Companies;
using AziendaPattern.Handlers;
using System;

namespace AziendaPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int numEmployees;
            //Console.WriteLine("How many employees?");
            ICompany company = null;
            //try
            //{
                //numEmployees = int.Parse(Console.ReadLine());
                
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            numEmployees = 2;
            CompanyFactory factory = new CompanyFactory(numEmployees);
            company = factory.CreateCompany();

            Employee employee1 = new Employee
            {
                Name = "Mario Rossi",
                BirthDate = new DateTime(1991, 6, 10),
                HiringDate = new DateTime(2015, 5, 5),
                ProductivityRate = 70,
                AbsencesRate = 10
                
            };
            Employee employee2 = new Employee 
            {
                Name = "Mario Bianchi",
                BirthDate = new DateTime(1995, 9, 23),
                HiringDate = new DateTime(2018, 3, 15),
                ProductivityRate = 65,
                AbsencesRate = 9
            };

            company.AddEmployee(employee1);
            company.AddEmployee(employee2);
            Console.WriteLine(company.Employees[0].Name);
            Console.WriteLine(company.Employees[1].Name);

            int Yvalue = 28;
            int Wvalue = 60;
            int Zvalue = 30;

            IHandler productivityHandler = new ProductivityHandler ();
            IHandler presenceHandler = new PresenceHandler ();
            IHandler seniorityHandler = new SeniorityHandler ();
            IHandler welfareHandler = new WelfareHandler ();

            productivityHandler.SetNext(presenceHandler).SetNext(seniorityHandler).SetNext(welfareHandler);

            foreach (Employee empl in company.Employees)
            {
                if (empl != null)
                {
                    Console.WriteLine($"{empl.Name} Bonus: {productivityHandler.HandleBonus(empl, Yvalue, Wvalue, Zvalue)} euro");
                }
            }

            if (company != null)
            {
                company.CompanyMessage("Messaggio di prova");
            }
        }
    }
}
