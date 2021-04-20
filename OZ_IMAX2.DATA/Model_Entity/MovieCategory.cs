using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OZ_IMAX2.DATA.Model_Entity
{
    public class MovieCategory : BaseClass
    {
        public int MovieCategoryId { get; set; }
        public string MovieCategoryName { get; set; }
        public string MovieCategoryDesc { get; set; }

        // Category-Movie (1-M)
        public List<Movie> MoviesOfCategory { get; set; }
    }
}
