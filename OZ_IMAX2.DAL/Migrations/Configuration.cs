namespace OZ_IMAX2.DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using OZ_IMAX2.DATA.Model_Entity;

    internal sealed class Configuration : DbMigrationsConfiguration<OZ_IMAX2.DAL.Context.SqlCinemaContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(OZ_IMAX2.DAL.Context.SqlCinemaContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            context.MovieCategoryTable.AddOrUpdate(new MovieCategory()
            {
                MovieCategoryName = "Science-Fiction",
                MovieCategoryDesc = "Speculative fiction that typically deals with imaginative and futuristic concepts.",
                DateCreated = DateTime.Now,
                DateModified = DateTime.Now,
                IsActive = true
            });
        }
    }
}
