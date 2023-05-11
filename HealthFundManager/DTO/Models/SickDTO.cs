using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Models
{
    public partial class SickDTO
    {
        public string Id { get; set; }
        public DateTime datePositiveResult { get; set; }
        public DateTime dateOfRecovery { get; set; }

    }
}
