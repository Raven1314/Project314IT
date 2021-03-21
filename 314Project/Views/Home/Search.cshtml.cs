using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _314Project.Data;
using _314Project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace _314Project.Views.Home
{
    public class SearchModel : PageModel
    {

        private readonly ApplicationDBContext _context;//Get database from DBcontext

        //IEnumerable<ApplicationUser> Search(string SearchTerm); 
        public SearchModel(_314Project.Data.ApplicationDBContext context)
        {
            _context = context;
        }


        public IList<ApplicationUser> Users { get; set; }

        [BindProperty(SupportsGet = true)]//binds form values and query strings with the same name as the property
        public string SearchTerm { get; set; }//Get user input
        public async Task OnGetAsync()
        {
            var users = from m in _context.ApplicationUser
                         select m;
            if (!string.IsNullOrEmpty(SearchTerm))
            {
                users = users.Where(s => s.UserName.Contains(SearchTerm));
            }

            Users = await users.ToListAsync();
        }
    }
}
