namespace StorageProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Alteracao : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Estoque", "Ingrediente_IngredienteID", "dbo.Ingrediente");
            DropIndex("dbo.Estoque", new[] { "Ingrediente_IngredienteID" });
            AddColumn("dbo.Ingrediente", "QuantEstoque", c => c.Int(nullable: false));
            AddColumn("dbo.Ingrediente", "Situacao", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Estoque", "Ingrediente_IngredienteID", c => c.Int());
            CreateIndex("dbo.Estoque", "Ingrediente_IngredienteID");
            AddForeignKey("dbo.Estoque", "Ingrediente_IngredienteID", "dbo.Ingrediente", "IngredienteID");
            DropColumn("dbo.Estoque", "QuantEstoque");
            DropColumn("dbo.Estoque", "Situacao");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Estoque", "Situacao", c => c.Boolean(nullable: false));
            AddColumn("dbo.Estoque", "QuantEstoque", c => c.Int(nullable: false));
            DropForeignKey("dbo.Estoque", "Ingrediente_IngredienteID", "dbo.Ingrediente");
            DropIndex("dbo.Estoque", new[] { "Ingrediente_IngredienteID" });
            AlterColumn("dbo.Estoque", "Ingrediente_IngredienteID", c => c.Int(nullable: false));
            DropColumn("dbo.Ingrediente", "Situacao");
            DropColumn("dbo.Ingrediente", "QuantEstoque");
            CreateIndex("dbo.Estoque", "Ingrediente_IngredienteID");
            AddForeignKey("dbo.Estoque", "Ingrediente_IngredienteID", "dbo.Ingrediente", "IngredienteID", cascadeDelete: true);
        }
    }
}
