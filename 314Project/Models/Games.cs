﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace _314Project.Models
{
    public class Games
    {
        public int ID { get; set; }

        [Display(Name = "Game")]
        public string GameName { get; set; }
        public virtual ICollection<Users> Users { get; set; }//Allow Users to get Games FKID (Foreign key ID)

    }
}
