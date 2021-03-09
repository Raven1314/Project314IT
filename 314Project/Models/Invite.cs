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

        [ForeignKey("UserId")]    //ICollection<Invite> in Games 
        [Display(Name = "Users")]
        public virtual ApplicationUser User { get; set; }

        //public virtual ICollection<ApplicationUser> ApplicationUser { get; set; }//Allow Users to get Games FKID (Foreign key ID)
    }
}
