using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StoreApp.ViewModels
{
    public class LoginVM
    {
        [Required(ErrorMessage ="Email ID Required")]
        [EmailAddress(ErrorMessage ="Invalid Email ID")]
        public string EmailID { get; set; }
        [Required(ErrorMessage ="Password Required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
