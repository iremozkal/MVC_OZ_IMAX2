using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OZ_IMAX2.DATA.Model_Entity
{
    public class Movie : BaseClass
    {
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public string MovieDesc { get; set; }

        // Category-Movie (1-M)
        public int MovieCategoryId { get; set; }
        public MovieCategory CategoryOfMovie { get; set; }

        // Detail-Movie (1-1)
        public MovieDetail DetailOfMovie { get; set; }

        // Artist-Movie (M-M)
        public List<RT_ArtistMovie> ArtistsOfMovie { get; set; }
    }
}
