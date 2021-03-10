using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace _314Project.Models
{
    public class ApplicationUser : IdentityUser
    {
  
        public string Description { get; set; }

        [ForeignKey("GameID")] //ICollection<Users> in Games Model
        [Display(Name = "Games")]
        public int GameID { get; set; }

        public string GameTag { get; set; }

        public virtual ICollection<Invite> Invite { get; set; }


    }
}
