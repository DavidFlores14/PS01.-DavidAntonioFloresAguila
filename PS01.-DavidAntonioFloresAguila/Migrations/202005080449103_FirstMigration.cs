namespace PS01._DavidAntonioFloresAguila.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        NombreC = c.String(),
                        Estado = c.String(),
                        Pais = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Capacidad = c.Int(nullable: false),
                        Invitado = c.String(),
                        Fecha = c.DateTime(nullable: false),
                        Negocio = c.String(),
                        IDCiudad_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Cities", t => t.IDCiudad_ID)
                .Index(t => t.IDCiudad_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Events", "IDCiudad_ID", "dbo.Cities");
            DropIndex("dbo.Events", new[] { "IDCiudad_ID" });
            DropTable("dbo.Events");
            DropTable("dbo.Cities");
        }
    }
}
