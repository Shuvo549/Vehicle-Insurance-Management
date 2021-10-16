using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vehicle_Insurance_Management_Sysytem.Models
{
    public class Users
    {
        [Key]
        public int Customerid { get; set; }
        [Required(ErrorMessage ="User Name Is Required")]
        public int Name { get; set; }
        [Required(ErrorMessage = "User Address Is Required")]
        public int Address { get; set; }
        [Required(ErrorMessage = "User Email Is Required")]
        public int Email { get; set; }
        [Required(ErrorMessage = "User Phone Is Required")]
        public int Phone { get; set; }
        [Required(ErrorMessage = "User Password Is Required")]
        public int Password { get; set; }

    }
}