using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NguyenThiLuong_31.Models
{
    [Table("PhongBans")]
    public class PhongBan
    {
        [Key]
        public int MaPhongBan { get; set; }
        [MaxLength(50)]
        public string TenPhongBan { get; set; }
        public ICollection<PhongBan> PhongBans { get; set; }
    }
}