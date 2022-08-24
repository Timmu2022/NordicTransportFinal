using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NordicTransportFinal.Data.Models.Domain
{
    public class Contract
    {
        [Key]
        public int ContractID { get; set; }

        public string ContractType { get; set; }

        public string ContractLength { get; set; }


        public virtual ICollection<CustVehicle> CustVehicles { get; set; }
    }
}
