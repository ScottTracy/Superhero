namespace Superhero.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Superhero.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Superhero.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Superhero.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Superhero.AddOrUpdate(n => n.ID,
            new Superheromodel { ID = 1, Name = "Ant Man", AlterEgo = "Dr. Henry(Hank) Pym", PrimaryAbility = "Shrink", SecondaryAbility = "Grow", Catchphrase = "unknown" },
            new Superheromodel { ID = 2, Name = "Aquaman", AlterEgo = "Arthur Joseph Curry", PrimaryAbility = "Breathe underwater", SecondaryAbility = "Talk to sea creatures", Catchphrase = "unknown" },
            new Superheromodel { ID = 3, Name = "Superman", AlterEgo = "Clark Kent", PrimaryAbility = "Fly", SecondaryAbility = "Superhuman strength", Catchphrase = "unknown" }
                
                );
        }
    }
}
