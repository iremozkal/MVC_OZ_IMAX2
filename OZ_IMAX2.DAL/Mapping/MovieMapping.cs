using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OZ_IMAX2.DATA.Model_Entity;
using System.Data.Entity.ModelConfiguration;

namespace OZ_IMAX2.DAL.Mapping
{
	public class MovieMapping : EntityTypeConfiguration<Movie>
	{
		public MovieMapping()
		{
			Property(x => x.MovieName).IsRequired().HasMaxLength(50).HasColumnName("Movie Name");
			Property(x => x.MovieDesc).HasColumnName("Movie Description").IsUnicode();

			// Category-Movie (1-M)
			HasRequired(x => x.CategoryOfMovie).WithMany(x => x.MoviesOfCategory).HasForeignKey(x => x.MovieCategoryId);
		}
	}
}
