using MegaDeskRP.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace MegaDeskRP.Pages
{
    public class DisplayQuoteModel : PageModel
    {

        public string? Name { get; set; }
        public int Width { get; set; }
        public int Depth { get; set; }
        public int NumOfDrawers { get; set; }

        public DesktopMaterial SurfaceMaterials { get; set; }

        public int RushDays { get; set; }

        [DataType(DataType.Date)]
        public DateTime QuoteDate { get; set; }
        public double QuoteTotal { get; set; }

        public void OnGet(string customerName, int width, int depth, int drawers, DesktopMaterial desktopMaterial, int rush, DateTime date, double quoteTotal)
        {
            Name = customerName;
            Width = width;
            Depth = depth;
            NumOfDrawers = drawers;
            SurfaceMaterials = desktopMaterial;
            RushDays = rush;
            QuoteDate = date;
            QuoteTotal = quoteTotal;
        }
        
    }
}
