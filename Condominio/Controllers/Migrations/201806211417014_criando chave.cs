namespace Controllers.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class criandochave : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Moradors",
                c => new
                    {
                        PlacaMId = c.String(nullable: false, maxLength: 128),
                        PresencaM = c.String(),
                        CarroM = c.String(),
                        NomeM = c.String(),
                        TelefoneM = c.String(),
                        Casa_numM = c.String(),
                        StatusM = c.String(),
                    })
                .PrimaryKey(t => t.PlacaMId);
            
            CreateTable(
                "dbo.Visitantes",
                c => new
                    {
                        PlacaVId = c.String(nullable: false, maxLength: 128),
                        PresencaV = c.String(),
                        CarroV = c.String(),
                        NomeV = c.String(),
                        TelefoneV = c.String(),
                        Visita = c.String(),
                    })
                .PrimaryKey(t => t.PlacaVId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Visitantes");
            DropTable("dbo.Moradors");
        }
    }
}
