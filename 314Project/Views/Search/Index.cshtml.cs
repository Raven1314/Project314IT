using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _314Project.Data;
using _314Project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace _314Project.Views.Search
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDBContext _context;//Get database from DBcontext

        public IndexModel(ApplicationDBContext context)
        {
            _context = context;
        }

        public IList<ApplicationUser> ApplicationUser { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        public async Task OnGetAsync()
        {
            var UserSearch = from p in _context.ApplicationUser
                             select p;
            if (!string.IsNullOrEmpty(SearchString))
            {
                UserSearch = UserSearch.Where(s => s.UserName.Contains(SearchString));
            }

            UserSearch = (IQueryable<ApplicationUser>)await UserSearch.ToListAsync();

        }
    }
}
