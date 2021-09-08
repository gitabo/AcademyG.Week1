using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AziendaPattern
{
    public class Employee
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime HiringDate { get; set; }
        public int ProductivityRate { get; set; }
        public int AbsencesRate { get; set; }

        public int eta { get { return DateTime.Today.Year - BirthDate.Year; } }

        public int anzianita { get { return DateTime.Today.Year - HiringDate.Year; } }

    }

}
