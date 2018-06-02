namespace ExampleMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataAnnotations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.MovieModels", "Title", c => c.String(maxLength: 60));
            AlterColumn("dbo.MovieModels", "Genre", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.MovieModels", "Rating", c => c.String(maxLength: 5));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MovieModels", "Rating", c => c.String());
            AlterColumn("dbo.MovieModels", "Genre", c => c.String());
            AlterColumn("dbo.MovieModels", "Title", c => c.String());
        }
    }
}
