using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetFirstTake.Models
{
	public static class DbInitializer
	{
		public static void Seed(AppDbContext context)
		{
			if (!context.Necklace.Any())
			{
				context.AddRange
				(
					new Necklace { Name = "Apple Pie", Price = 12.95M, Description = "Our famous apple pies!", ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg", IsNecklaceOfTheWeek = true, ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg" },
					new Necklace { Name = "Blueberry Cheese Cake", Price = 18.95M, Description = "You'll love it!", ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecake.jpg", IsNecklaceOfTheWeek = false, ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecakesmall.jpg" },
					new Necklace { Name = "Cheese Cake", Price = 18.95M, Description = "Plain cheese cake. Plain pleasure.",  ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecake.jpg", IsNecklaceOfTheWeek = false, ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecakesmall.jpg" },
					new Necklace { Name = "Cherry Pie", Price = 15.95M, Description = "A summer classic!", ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cherrypie.jpg", IsNecklaceOfTheWeek = false, ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cherrypiesmall.jpg" },
					new Necklace { Name = "Christmas Apple Pie", Price = 13.95M, Description = "Happy holidays with this pie!", ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/christmasapplepie.jpg", IsNecklaceOfTheWeek = false, ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/christmasapplepiesmall.jpg" },
					new Necklace { Name = "Cranberry Pie", Price = 17.95M, Description = "A Christmas favorite", ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cranberrypie.jpg", IsNecklaceOfTheWeek = false, ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cranberrypiesmall.jpg" },
					new Necklace { Name = "Peach Pie", Price = 15.95M, Description = "Sweet as peach", ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/peachpie.jpg", IsNecklaceOfTheWeek = false, ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/peachpiesmall.jpg" },
					new Necklace { Name = "Pumpkin Pie", Price = 12.95M, Description = "Our Halloween favorite", ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpie.jpg", IsNecklaceOfTheWeek = true, ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpiesmall.jpg" },
					new Necklace { Name = "Rhubarb Pie", Price = 15.95M, Description = "My God, so sweet!", ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpie.jpg", IsNecklaceOfTheWeek = true, ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpiesmall.jpg" },
					new Necklace { Name = "Strawberry Pie", Price = 15.95M, Description = "Our delicious strawberry pie!", ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypie.jpg", IsNecklaceOfTheWeek = false, ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypiesmall.jpg" },
					new Necklace { Name = "Strawberry Cheese Cake", Price = 18.95M, Description = "You'll love it!", ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrycheesecake.jpg", IsNecklaceOfTheWeek = false, ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrycheesecakesmall.jpg" }
				);
				context.SaveChanges();
			}
		}
	}
}
