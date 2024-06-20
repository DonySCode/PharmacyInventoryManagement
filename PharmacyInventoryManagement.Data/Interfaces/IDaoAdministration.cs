using PharmacyInventoryManagement.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyInventoryManagement.Data.Interfaces
{
    public interface IDaoAdministration
    {
        List<Administration> GetAdministrations();
        Administration GetAdministration(int Id);
        void SaveAdministration(Administration administration);
        void UpdateAdministration(Administration administration);
        void RemoveAdministration(Administration administration);
    }
}
