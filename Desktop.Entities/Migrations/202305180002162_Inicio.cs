namespace Desktop.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicio : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Computoes",
                c => new
                    {
                        ComputoId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 80),
                        Edificio = c.String(nullable: false, maxLength: 80),
                        NumeroComputo = c.String(nullable: false, maxLength: 80),
                        Desktop = c.Int(nullable: false),
                        Desktops_DesktopId = c.Int(),
                    })
                .PrimaryKey(t => t.ComputoId)
                .ForeignKey("dbo.Desktopps", t => t.Desktops_DesktopId)
                .Index(t => t.Desktops_DesktopId);
            
            CreateTable(
                "dbo.Desktopps",
                c => new
                    {
                        DesktopId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50),
                        Marca = c.String(nullable: false, maxLength: 50),
                        Procesador = c.String(nullable: false, maxLength: 50),
                        MemoriaRAM = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.DesktopId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Computoes", "Desktops_DesktopId", "dbo.Desktopps");
            DropIndex("dbo.Computoes", new[] { "Desktops_DesktopId" });
            DropTable("dbo.Desktopps");
            DropTable("dbo.Computoes");
        }
    }
}
