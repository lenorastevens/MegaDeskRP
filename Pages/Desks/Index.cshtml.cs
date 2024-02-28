using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MegaDeskRP.Data;
using MegaDeskRP.Models;

namespace MegaDeskRP.Pages.Desks
{
    public class IndexModel : PageModel
    {
        private readonly MegaDeskRPContext _context;

        public IndexModel(MegaDeskRPContext context)
        {
            _context = context;
        }

        public IList<Desk> Desk { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Desk = await _context.Desk.ToListAsync();
        }
    }
}
