using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NordicTransportFinal.Data.Models.Domain
{
    public class Role
    {
        [Key]
        public int RoleID { get; set; }

        public string RoleName { get; set; }

        public string RoleDescription { get; set; }
         
        public virtual ICollection<User> Users { get; set; }
    }
}
