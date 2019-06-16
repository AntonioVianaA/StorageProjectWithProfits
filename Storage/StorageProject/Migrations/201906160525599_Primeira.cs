namespace StorageProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Primeira : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Estoque", "Ingrediente_IngredienteID", c => c.Int(nullable: false));
            CreateIndex("dbo.Estoque", "Ingrediente_IngredienteID");
            AddForeignKey("dbo.Estoque", "Ingrediente_IngredienteID", "dbo.Ingrediente", "IngredienteID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Estoque", "Ingrediente_IngredienteID", "dbo.Ingrediente");
            DropIndex("dbo.Estoque", new[] { "Ingrediente_IngredienteID" });
            DropColumn("dbo.Estoque", "Ingrediente_IngredienteID");
        }
    }
}
