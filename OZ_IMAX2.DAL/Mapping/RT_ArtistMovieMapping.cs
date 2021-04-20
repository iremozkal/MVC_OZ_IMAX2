using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OZ_IMAX2.DATA.Model_Entity;
using System.Data.Entity.ModelConfiguration;

namespace OZ_IMAX2.DAL.Mapping
{
	public class RT_ArtistMovieMapping : EntityTypeConfiguration<RT_ArtistMovie>
	{
		public RT_ArtistMovieMapping()
		{
			HasKey(x => x.RT_ArtistMovieId);
			Property(x => x.WorkDays).IsRequired();

			// Artist-Movie (M-M)
			HasRequired(x => x.ArtistOfMovie).WithMany(x => x.MoviesOfArtist).HasForeignKey(x => x.ArtistId);
			HasRequired(x => x.MovieOfArtist).WithMany(x => x.ArtistsOfMovie).HasForeignKey(x => x.MovieId);
		}
	}
}
