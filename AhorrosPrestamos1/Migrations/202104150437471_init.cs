namespace AhorrosPrestamos1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ahorros",
                c => new
                    {
                        ID_Saving = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Last_Name = c.String(),
                        Nationality = c.String(),
                        Identification = c.String(),
                        Material_Status = c.String(),
                        Phone_Number = c.String(),
                        Home_Phone = c.String(),
                        Email = c.String(),
                        Address = c.String(),
                        Account_type = c.String(),
                        Currency = c.String(),
                    })
                .PrimaryKey(t => t.ID_Saving);
            
            CreateTable(
                "dbo.Solicitud",
                c => new
                    {
                        RequesterID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Last_Name = c.String(),
                        Nationality = c.String(),
                        Identification = c.String(),
                        Material_Status = c.String(),
                        Phone_Number = c.String(),
                        Home_Phone = c.String(),
                        Email = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.RequesterID);
            
            AddColumn("dbo.Prestamo", "Last_Name", c => c.String());
            AddColumn("dbo.Prestamo", "solicitud_RequesterID", c => c.Int());
            CreateIndex("dbo.Prestamo", "solicitud_RequesterID");
            AddForeignKey("dbo.Prestamo", "solicitud_RequesterID", "dbo.Solicitud", "RequesterID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Prestamo", "solicitud_RequesterID", "dbo.Solicitud");
            DropIndex("dbo.Prestamo", new[] { "solicitud_RequesterID" });
            DropColumn("dbo.Prestamo", "solicitud_RequesterID");
            DropColumn("dbo.Prestamo", "Last_Name");
            DropTable("dbo.Solicitud");
            DropTable("dbo.Ahorros");
        }
    }
}
