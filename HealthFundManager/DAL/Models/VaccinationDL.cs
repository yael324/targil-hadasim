using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public partial class VaccinationDL
    {
        public string Id { get; set; }
        public DateTime DateOfVaccination { get; set; }
        public string VaccineProducer { get; set; }

        public virtual EmployeeDL Employee { get; set; }
    }
}
