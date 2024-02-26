using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Lab2_A2.Models;

namespace Lab2_A2.Pages.Student_Page
{
    public class IndexModel : PageModel
    {
        private readonly Lab2_A2.Models.SchoolContextDbContext _context;

        public IndexModel(Lab2_A2.Models.SchoolContextDbContext context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Student = await _context.Students.ToListAsync();
        }
    }
}
