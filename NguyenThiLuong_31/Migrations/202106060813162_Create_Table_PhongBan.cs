namespace NguyenThiLuong_31.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_PhongBan : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PhongBans",
                c => new
                    {
                        MaPhongBan = c.Int(nullable: false, identity: true),
                        TenPhongBan = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.MaPhongBan);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PhongBans");
        }
    }
}
