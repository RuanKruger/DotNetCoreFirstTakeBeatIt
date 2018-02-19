using DotNetFirstTake.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetFirstTake.ViewModels
{
    public class HomeViewModel
    {
		public string Title { get; set; }
		public List<Necklace> Necklaces { get; set; }
    }
}
