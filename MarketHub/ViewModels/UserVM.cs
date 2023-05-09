using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StoreApp.ViewModels
{
    public class UserVM
    {
        [Required(ErrorMessage ="First Name Required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage ="Last Name Required")]
        public string LastName { get; set; }
        [Required(ErrorMessage ="Address Required")]
        public string Address { get; set; }
        [Required(ErrorMessage ="Email ID Requiered")]
        [EmailAddress(ErrorMessage ="Invalid Email ID")]
        public string EmailID { get; set; }
        [Required(ErrorMessage ="Mobile No Required")]
        public string MobileNo { get; set; }
        [Required(ErrorMessage ="Password Required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "Confirm Password Required")]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="Password and Confirm Password are not Same!")]
        public string ConfirmPassword { get; set; }
    }
}
