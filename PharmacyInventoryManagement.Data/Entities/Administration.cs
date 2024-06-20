using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyInventoryManagement.Data.Entities
{
    public class Administration
    {
        public int Id { get; set; }
        public string? AdministrationType { get; set; }
        public string? Description { get; set; }
    }
}
