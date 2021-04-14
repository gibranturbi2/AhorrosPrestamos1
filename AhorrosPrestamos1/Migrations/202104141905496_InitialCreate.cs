namespace AhorrosPrestamos1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Prestamo",
                c => new
                    {
                        ID_Loan = c.Int(nullable: false, identity: true),
                        Name_Client = c.String(),
                        Amount = c.Double(nullable: false),
                        Interest = c.Double(nullable: false),
                        Share = c.Double(nullable: false),
                        Payment_fee = c.Double(nullable: false),
                        Total_Amount = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ID_Loan);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Prestamo");
        }
    }
}
