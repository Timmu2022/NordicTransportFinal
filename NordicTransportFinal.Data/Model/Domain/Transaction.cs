using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NordicTransportFinal.Data.Models.Domain
{
    public class Transaction

    {

        [Key]
        public int TransactionID { get; set; }
        public Double DistanceTravelled { get; set; }
        public Double Price { get; set; }
        public Double Total { get; set; }

        public bool IsPaymentCompleted { get; set; }

    }
}