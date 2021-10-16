using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Vehicle_Insurance_Management_System.Models
{
    public class Customers
    {
        [Key]
        public int CustomerID {get;set;}
        [Required(ErrorMessage = "Customer Name Is Required")]
        public string CustomerName { get; set; }
        [Required(ErrorMessage = "Customer Email Is Required")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "Invalid Email")]
        [Remote("IsEmailExists", "Home", ErrorMessage = "Email already exists!")]
        public string CustomerEmail { get; set; }
        [Required(ErrorMessage = "Customer Phone Number Is Required")]
        [StringLength(maximumLength: 11, MinimumLength = 11, ErrorMessage = "Invalid Phone number")]
        public string CustomerPhoneNumber { get; set; }
        [Required(ErrorMessage = "Customer Address Is Required")]
        public string CustomerAddress { get; set; }
        [Required(ErrorMessage = "Customer NID Is Required")]
        public string CustomerNID { get; set; }
        [Required(ErrorMessage = "Customer Occupation Is Required")]
        public string CustomerOccupation { get; set; }
        [Required(ErrorMessage = "Customer password Is Required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "Customer Confirm password Is Required")]
        [System.ComponentModel.DataAnnotations.Compare("Password")]
        [DataType(DataType.Password)]
        public string Confirm_Password { get; set; }







    }
}