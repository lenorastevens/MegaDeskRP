using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MegaDeskRP.Data;
using MegaDeskRP.Models;
using MegaDeskRP.Services;

namespace MegaDeskRP.Pages.Desks
{
    public class CreateModel : PageModel
    {
        private readonly DeskQuoteService _deskQuoteService;
        private readonly MegaDeskRP.Data.MegaDeskRPContext _context;

        public CreateModel(DeskQuoteService deskQuoteService, MegaDeskRPContext context)
        {
            _deskQuoteService = deskQuoteService;
            _context = context;
        }
      


        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Desk Desk { get; set; } = default!;

        public decimal QuoteTotal { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            QuoteTotal = _deskQuoteService.CalculateDeskQuoteTotal(Desk);

            _context.Desk.Add(Desk);
            await _context.SaveChangesAsync();
            //return RedirectToPage("./Index");

            return RedirectToPage("/DisplayQuote", new { customerName = Desk.CustomerName, width = Desk.Width, depth = Desk.Width, drawers = Desk.NumOfDrawers, desktopMaterial = Desk.SurfaceMaterials, rush = Desk.RushDays, date = Desk.QuoteDate, quoteTotal = QuoteTotal });
        }
    }
}
