using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OZ_IMAX2.DATA.Model_Entity
{
    public class Artist : BaseClass
    {
        public int ArtistId { get; set; }
        public string ArtistName { get; set; }
        public DateTime ArtistBirthDate { get; set; }
        public string ArtistDesc { get; set; }
        // public decimal ArtistPayment { get; set; }

        // Artist-Movie (M-M)
        public List<RT_ArtistMovie> MoviesOfArtist { get; set; }
    }
}
