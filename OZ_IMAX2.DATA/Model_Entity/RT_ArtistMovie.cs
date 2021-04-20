using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OZ_IMAX2.DATA.Model_Entity
{
    public class RT_ArtistMovie : BaseClass
    {
        public int RT_ArtistMovieId { get; set; }
        public int WorkDays { get; set; }

        // Artist-Movie (M-M)

        public int ArtistId { get; set; }
        public Artist ArtistOfMovie { get; set; }

        public int MovieId { get; set; }
        public Movie MovieOfArtist { get; set; }
    }
}
