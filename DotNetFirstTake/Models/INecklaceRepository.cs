using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetFirstTake.Models
{
    public interface INecklaceRepository
    {
		IEnumerable<Necklace> GetAllNecklaces();
		Necklace GetNecklaceById(int necklaceId);
	    void AddNecklaceInDb(Necklace necklace);
	}
}
