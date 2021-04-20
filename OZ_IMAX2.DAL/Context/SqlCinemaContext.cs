using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OZ_IMAX2.DATA.Model_Entity;
using OZ_IMAX2.DAL.Mapping;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace OZ_IMAX2.DAL.Context
{
	public class SqlCinemaContext : DbContext
	{
		public SqlCinemaContext()
			: base("Server=.; Database=Cinema2DB; Integrated Security=SSPI")
		{

		}

		public DbSet<Movie> MovieTable { get; set; }
		public DbSet<MovieCategory> MovieCategoryTable { get; set; }
		public DbSet<Artist> ArtistTable { get; set; }
		public DbSet<MovieDetail> MovieDetailTable { get; set; }
		public DbSet<RT_ArtistMovie> RT_ArtistMovieTable { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Configurations.Add(new MovieMapping());
			modelBuilder.Configurations.Add(new MovieDetailMapping());
			modelBuilder.Configurations.Add(new RT_ArtistMovieMapping());

			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

			base.OnModelCreating(modelBuilder);
		}

	}
}
