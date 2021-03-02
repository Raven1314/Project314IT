using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace _314Project.Models
{
    public class Invite
    {
        public int ID { get; set; }

        [Display(Name = "Users")]
        [ForeignKey("UsersID")]
        public int UsersID { get; set; }
    }
}
