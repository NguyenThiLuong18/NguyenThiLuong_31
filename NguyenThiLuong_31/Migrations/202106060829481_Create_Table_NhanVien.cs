namespace NguyenThiLuong_31.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_NhanVien : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NhanViens",
                c => new
                    {
                        MaNhanVien = c.String(nullable: false, maxLength: 20),
                        HoTen = c.String(maxLength: 50),
                        PhongBan_MaPhongBan = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaNhanVien)
                .ForeignKey("dbo.PhongBans", t => t.PhongBan_MaPhongBan, cascadeDelete: true)
                .Index(t => t.PhongBan_MaPhongBan);
            
            AddColumn("dbo.PhongBans", "PhongBan_MaPhongBan", c => c.Int());
            CreateIndex("dbo.PhongBans", "PhongBan_MaPhongBan");
            AddForeignKey("dbo.PhongBans", "PhongBan_MaPhongBan", "dbo.PhongBans", "MaPhongBan");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.NhanViens", "PhongBan_MaPhongBan", "dbo.PhongBans");
            DropForeignKey("dbo.PhongBans", "PhongBan_MaPhongBan", "dbo.PhongBans");
            DropIndex("dbo.PhongBans", new[] { "PhongBan_MaPhongBan" });
            DropIndex("dbo.NhanViens", new[] { "PhongBan_MaPhongBan" });
            DropColumn("dbo.PhongBans", "PhongBan_MaPhongBan");
            DropTable("dbo.NhanViens");
        }
    }
}
