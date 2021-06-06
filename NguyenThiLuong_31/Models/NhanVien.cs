using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NguyenThiLuong_31.Models
{
    [Table("NhanViens")]
    public class NhanVien
    {
        [Key]
        [MaxLength(20)]
        public string MaNhanVien { get; set; }
        [MaxLength(50)]
        public string HoTen { get; set; }
        public int PhongBan_MaPhongBan { get; set; }
        [ForeignKey("PhongBan_MaPhongBan")]
        public virtual PhongBan PhongBan { get; set; }
    }
}