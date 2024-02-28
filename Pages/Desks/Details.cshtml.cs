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
    public class DetailsModel : PageModel
    {
        private readonly MegaDeskRP.Data.MegaDeskRPContext _context;

        public DetailsModel(MegaDeskRP.Data.MegaDeskRPContext context)
        {
            _context = context;
        }

        public Desk Desk { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var desk = await _context.Desk.FirstOrDefaultAsync(m => m.Id == id);
            if (desk == null)
            {
                return NotFound();
            }
            else
            {
                Desk = desk;
            }
            return Page();
        }
    }
}
