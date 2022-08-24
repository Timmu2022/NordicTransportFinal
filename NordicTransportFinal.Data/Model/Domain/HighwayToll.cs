using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NordicTransportFinal.Data.Models.Domain
{
    public class HighwayToll
    {
        [Key]
        public int HighwayTollID { get; set; }
        public Double TollPrice { get; set; }
        public string TollName { get; set; }

        public virtual ICollection<Transaction> Transactions { get; set; } 

    }
}

