using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NordicTransportFinal.Data.Models.Domain 
{
    public class User
    {
        [Key]
        [Required]
        public string UserID { get; set; }

        [Required]
        public string UForename { get; set; }

        [Required]
        public string USurname { get; set; }

        [Required]
        public string UEmail { get; set; }

        [Required]
        public DateTime UDOB { get; set; }

        [Required]
        public string UAddress { get; set; }

        [Required]
        public string UPostcode { get; set; }

        [Required]
        public string UPassword { get; set; } 

        public virtual ICollection<Contract> Contracts { get; set; }

    }
}
