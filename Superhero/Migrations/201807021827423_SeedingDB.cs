namespace Superhero.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedingDB : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Superheroes", newName: "Superheromodels");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Superheromodels", newName: "Superheroes");
        }
    }
}
