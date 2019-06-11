namespace StorageProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Primeira : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Endereco",
                c => new
                    {
                        EnderecoID = c.Int(nullable: false, identity: true),
                        Rua = c.String(),
                        Cep = c.String(nullable: false),
                        Pais = c.String(),
                        Numero = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EnderecoID);
            
            CreateTable(
                "dbo.Estoque",
                c => new
                    {
                        EstoqueID = c.Int(nullable: false, identity: true),
                        QuantEstoque = c.Int(nullable: false),
                        Situacao = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.EstoqueID);
            
            CreateTable(
                "dbo.Historicos",
                c => new
                    {
                        HistoricoID = c.Int(nullable: false, identity: true),
                        ValorTotal = c.Double(nullable: false),
                        ValorGasto = c.Double(nullable: false),
                        Lucro = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.HistoricoID);
            
            CreateTable(
                "dbo.Ingrediente",
                c => new
                    {
                        IngredienteID = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        Descricao = c.String(nullable: false),
                        Validade = c.DateTime(nullable: false),
                        Preco = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.IngredienteID);
            
            CreateTable(
                "dbo.Ingredientes_Receita",
                c => new
                    {
                        Ingredientes_ReceitaID = c.Int(nullable: false, identity: true),
                        Quantidade = c.Double(nullable: false),
                        Ingrediente_IngredienteID = c.Int(),
                        Receita_ReceitaID = c.Int(),
                    })
                .PrimaryKey(t => t.Ingredientes_ReceitaID)
                .ForeignKey("dbo.Ingrediente", t => t.Ingrediente_IngredienteID)
                .ForeignKey("dbo.Receita", t => t.Receita_ReceitaID)
                .Index(t => t.Ingrediente_IngredienteID)
                .Index(t => t.Receita_ReceitaID);
            
            CreateTable(
                "dbo.Produto",
                c => new
                    {
                        ProdutoID = c.Int(nullable: false, identity: true),
                        Status = c.Boolean(nullable: false),
                        Preco = c.Double(nullable: false),
                        TempoProducao = c.DateTime(nullable: false),
                        QuantidadeReceita = c.Double(nullable: false),
                        Porcoes = c.Int(nullable: false),
                        ProduzidoEm = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ProdutoID);
            
            CreateTable(
                "dbo.Receita",
                c => new
                    {
                        ReceitaID = c.Int(nullable: false, identity: true),
                        ModoPreparo = c.String(nullable: false),
                        Nome = c.String(nullable: false),
                        Rendimento = c.Int(nullable: false),
                        CadastradoEm = c.DateTime(nullable: false),
                        TempoPreparo = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ReceitaID);
            
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        UsuarioID = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        Sobrenome = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Username = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        Cpf = c.String(nullable: false),
                        Imagem = c.String(),
                        DataCadastro = c.DateTime(nullable: false),
                        UltimoLogin = c.DateTime(nullable: false),
                        Endereco_EnderecoID = c.Int(),
                        Historico_HistoricoID = c.Int(),
                        Produto_ProdutoID = c.Int(),
                    })
                .PrimaryKey(t => t.UsuarioID)
                .ForeignKey("dbo.Endereco", t => t.Endereco_EnderecoID)
                .ForeignKey("dbo.Historicos", t => t.Historico_HistoricoID)
                .ForeignKey("dbo.Produto", t => t.Produto_ProdutoID)
                .Index(t => t.Endereco_EnderecoID)
                .Index(t => t.Historico_HistoricoID)
                .Index(t => t.Produto_ProdutoID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Usuario", "Produto_ProdutoID", "dbo.Produto");
            DropForeignKey("dbo.Usuario", "Historico_HistoricoID", "dbo.Historicos");
            DropForeignKey("dbo.Usuario", "Endereco_EnderecoID", "dbo.Endereco");
            DropForeignKey("dbo.Ingredientes_Receita", "Receita_ReceitaID", "dbo.Receita");
            DropForeignKey("dbo.Ingredientes_Receita", "Ingrediente_IngredienteID", "dbo.Ingrediente");
            DropIndex("dbo.Usuario", new[] { "Produto_ProdutoID" });
            DropIndex("dbo.Usuario", new[] { "Historico_HistoricoID" });
            DropIndex("dbo.Usuario", new[] { "Endereco_EnderecoID" });
            DropIndex("dbo.Ingredientes_Receita", new[] { "Receita_ReceitaID" });
            DropIndex("dbo.Ingredientes_Receita", new[] { "Ingrediente_IngredienteID" });
            DropTable("dbo.Usuario");
            DropTable("dbo.Receita");
            DropTable("dbo.Produto");
            DropTable("dbo.Ingredientes_Receita");
            DropTable("dbo.Ingrediente");
            DropTable("dbo.Historicos");
            DropTable("dbo.Estoque");
            DropTable("dbo.Endereco");
        }
    }
}
