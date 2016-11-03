namespace jQuery_CRUD.Migrations
{
    using jQuery_CRUD.DAL;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<jQuery_CRUD.DAL.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(jQuery_CRUD.DAL.DataContext context)
        {
            context.Users.Add(new User { Name = "Shailendra", Address = "Delhi", ContactNo = "9876543210" });
        }
    }
}
