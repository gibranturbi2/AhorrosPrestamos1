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
                "dbo.Prestamo",
                c => new
                    {
                        ID_Loan = c.Int(nullable: false, identity: true),
                        Name_Client = c.String(),
                        Last_Name = c.String(),
                        Amount = c.Double(nullable: false),
                        Interest = c.Double(nullable: false),
                        Share = c.Double(nullable: false),
                        Payment_fee = c.Double(nullable: false),
                        Total_Amount = c.Double(nullable: false),
                        solicitud_RequesterID = c.Int(),
                    })
                .PrimaryKey(t => t.ID_Loan)
                .ForeignKey("dbo.Solicitud", t => t.solicitud_RequesterID)
                .Index(t => t.solicitud_RequesterID);
            
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
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Prestamo", "solicitud_RequesterID", "dbo.Solicitud");
            DropIndex("dbo.Prestamo", new[] { "solicitud_RequesterID" });
            DropTable("dbo.Solicitud");
            DropTable("dbo.Prestamo");
            DropTable("dbo.Ahorros");
        }
    }
}
