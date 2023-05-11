using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public partial class SickDL
    {
        public string Id { get; set; }
        public DateTime datePositiveResult { get; set; }
        public DateTime dateOfRecovery { get; set; }

        public virtual EmployeeDL Employee { get; set; }

    }
}
