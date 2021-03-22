using _314Project.Data;
using _314Project.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _314Project.Controllers
{
    public class SearchController : Controller
    {
        private readonly ApplicationDBContext _context;//Get database from DBcontext



        public SearchController(ApplicationDBContext context)
        {
            _context = context;
        }

        public IList<ApplicationUser> Movie { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        public IActionResult Index()
        {
            return View();
        }
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
