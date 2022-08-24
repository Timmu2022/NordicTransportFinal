using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NordicTransportFinal.Services.Models
{
    public class ContractUserModel
    {
        [Display(Name = "Contract Type")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Contract Type Required")]
        public string ContractType { get; set; }

        [Display(Name = "Contract Length")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Contract Length Required")]
        public string ContractLength { get; set; }

        public string User { get; set; }
    }
}
