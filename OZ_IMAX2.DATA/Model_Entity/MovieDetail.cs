using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OZ_IMAX2.DATA.Model_Entity
{
    public class MovieDetail : BaseClass
    {
        // It doesn't have its own id, it uses movie id from movie table as a primary key.
        public int MovieId { get; set; }
        public string DetailDesc { get; set; }
        public DateTime ProductionYear { get; set; }
        public string Director { get; set; }
        //public int OscarCount { get; set; }
        //public string Region { get; set; }
        //public int MovieScore { get; set; }

        // Detail-Movie (1-1)
        public Movie MovieOfDetail { get; set; }
    }
}
