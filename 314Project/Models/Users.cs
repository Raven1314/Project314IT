using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace _314Project.Models
{
    public class Users
    {
        public int ID { get; set; }

        [Display(Name = "Username")]//Display for the column name. need to be placed on top of the column 
        public string UserName { get; set; }

        public string Email { get; set; }

        [Display(Name = "Password")]
        public string Password { get; set; }

        [ForeignKey("GamesID")] //ICollection<Users> in Games Model
        [Display(Name = "Games")]
        public int GamesID { get; set; }

        public int GameTag { get; set; }
        

        public virtual ICollection<Invite> Invite { get; set; }


    }
}
