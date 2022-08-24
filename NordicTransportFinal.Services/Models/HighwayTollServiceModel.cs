using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NordicTransportFinal.Services.Models
{
    public class HighwayTollServiceModel
    {
        [Display(Name = "Toll Price")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Toll Price Required")]
        public Double TollPrice { get; set; }

        [Display(Name = "Toll Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Toll Name Required")]
        public string TollName { get; set; }
        public int Location { get; set; }
    }
}
