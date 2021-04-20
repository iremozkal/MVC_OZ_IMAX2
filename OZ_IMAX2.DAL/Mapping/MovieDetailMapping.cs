using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OZ_IMAX2.DATA.Model_Entity;
using System.Data.Entity.ModelConfiguration;

namespace OZ_IMAX2.DAL.Mapping
{
	public class MovieDetailMapping : EntityTypeConfiguration<MovieDetail>
	{
		public MovieDetailMapping()
		{
			HasKey(x => x.MovieId);

			// Detail-Movie (1-1)
			HasRequired(x => x.MovieOfDetail).WithOptional(x => x.DetailOfMovie);
		}
	}
}
