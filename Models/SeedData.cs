using Microsoft.EntityFrameworkCore;
using MegaDeskRP.Data;
using MegaDeskRP.Models;
using Microsoft.CodeAnalysis;
using Microsoft.Extensions.DependencyInjection;

namespace MegaDeskRP.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var context = new MegaDeskRPContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MegaDeskRPContext>>());
            if (context == null || context.Desk == null)
            {
                throw new ArgumentNullException("Null MegaDeskRPContext");
            }

            // Look for any movies.
            if (context.Desk.Any())
            {
                return;   // DB has been seeded
            }

            context.Desk.AddRange(
                new Desk
                {
                    CustomerName = "Test Customer",
                    Width = 25,
                    Depth = 23,
                    NumOfDrawers = 3,
                    SurfaceMaterials = DesktopMaterial.Laminate,
                    QuoteDate = DateTime.Parse("2024-2-07"),
                    RushDays = 3
                },

                new Desk
                {
                    CustomerName = "Test Customer",
                    Width = 35,
                    Depth = 30,
                    NumOfDrawers = 5,
                    SurfaceMaterials = DesktopMaterial.Pine,
                    QuoteDate = DateTime.Parse("2024-2-04"),
                    RushDays = 5,
                },

                new Desk
                {
                    CustomerName = "Test Customer",
                    Width = 45,
                    Depth = 35,
                    NumOfDrawers = 2,
                    SurfaceMaterials = DesktopMaterial.Oak,
                    QuoteDate = DateTime.Parse("2024-2-01"),
                    RushDays = 7,
                },

                new Desk
                {
                    CustomerName = "Test Customer",
                    Width = 60,
                    Depth = 40,
                    NumOfDrawers = 7,
                    SurfaceMaterials = DesktopMaterial.Rosewood,
                    QuoteDate = DateTime.Parse("2024-2-03"),
                    RushDays = 14,
                },
                 new Desk
                 {
                     CustomerName = "Test Customer",
                     Width = 85,
                     Depth = 45,
                     NumOfDrawers = 1,
                     SurfaceMaterials = DesktopMaterial.Veneer,
                     QuoteDate = DateTime.Parse("2024-2-25"),
                     RushDays = 3,
                 }
            );

            context.SaveChanges();
        }
    }

}
