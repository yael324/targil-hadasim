using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Models
{
    public partial class VaccinationDTO
    {
        public string Id { get; set; }
        public DateTime DateOfVaccination { get; set; }
        public string VaccineProducer { get; set; }
    }
}
