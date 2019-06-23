namespace StorageProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Primeiraa : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Endereco", "Numero", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Endereco", "Numero", c => c.Int(nullable: false));
        }
    }
}
