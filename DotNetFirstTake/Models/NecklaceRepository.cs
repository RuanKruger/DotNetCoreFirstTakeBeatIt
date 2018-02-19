using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetFirstTake.Models
{
    public class NecklaceRepository : INecklaceRepository
    {
		private readonly AppDbContext _appDbContext;

		public NecklaceRepository(AppDbContext appDbContext)
		{
			_appDbContext = appDbContext;
		}

		public IEnumerable<Necklace> GetAllNecklaces()
		{
			return _appDbContext.Necklace;
		}

		public Necklace GetNecklaceById(int necklaceId)
		{
			return _appDbContext.Necklace.FirstOrDefault(x => x.Id == necklaceId);
		}
	    public void AddNecklaceInDb(Necklace necklace)
	    {
		    _appDbContext.Necklace.Add(necklace);
		    _appDbContext.SaveChanges();
	    }
	}
}
