using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetFirstTake.Models
{
    public class Necklace
    {
		public int Id { get; set; }
		[Required]
		[StringLength(100, ErrorMessage = "The Name of the item is required")]
		public string Name { get; set; }
	    [Required]
	    [StringLength(100, ErrorMessage = "The Description of the item is required")]
		public string Description { get; set; }
	    [Required]
		public decimal Price { get; set; }
	    [Required(ErrorMessage = "The Image Url of the item is required")]
		public string ImageUrl { get; set; }
	    [Required(ErrorMessage = "The Image Thumbnail Url of the item is required")]
		public string ImageThumbnailUrl { get; set; }
		public bool IsNecklaceOfTheWeek { get; set; }
		public bool IsInStock { get; set; }
	}
}
