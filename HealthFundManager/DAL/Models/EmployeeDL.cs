using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public partial class EmployeeDL
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? Phone { get; set; }
        public string MobilePhone { get; set; }
        public virtual ICollection<VaccinationDL> Vaccinations { get; set; }
        public virtual ICollection<SickDL> Sicks { get; set; }
    }
}
