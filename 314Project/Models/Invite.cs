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

        [ForeignKey("UserId")]    //ICollection<Invite> in User 
        [Display(Name = "Users")]
        public virtual ApplicationUser User { get; set; }
    }
}
