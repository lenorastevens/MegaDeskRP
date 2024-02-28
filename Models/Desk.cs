using MegaDeskRP.Services;
using System.ComponentModel.DataAnnotations;

namespace MegaDeskRP.Models
{

    public enum DesktopMaterial { Laminate, Oak, Pine, Rosewood, Veneer }
    public class Desk
    {
        //Create the contants
        public const int MINWIDTH = 24;

        public const int MAXWIDTH = 96;

        public const int MINDEPTH = 12;

        public const int MAXDEPTH = 48;




        //Create the private data members of the Desk Class
        public int Id { get; set; }
        public string? CustomerName { get; set; }
        public int Width { get; set; }

        public int Depth { get; set; }

        public int NumOfDrawers { get; set; }

        public DesktopMaterial SurfaceMaterials { get; set; }
         
        public int RushDays { get; set; }

        [DataType(DataType.Date)]
        public DateTime QuoteDate { get; set; }

        public Desk()
        {
            
        }

    }
}
