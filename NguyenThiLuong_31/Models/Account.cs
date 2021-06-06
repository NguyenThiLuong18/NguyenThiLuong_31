using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NguyenThiLuong_31.Models
{
    [Table("Accounts")]
    public class Account
    {
        [Key]
        //Validation with Model
        //UserName k được để trống
        [Required(ErrorMessage = "Username is required.")]
        public string Username { get; set; }
        //password k được để trống 
        [Required(ErrorMessage = "Password is required.")]
        //Định nghĩa DataType
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}