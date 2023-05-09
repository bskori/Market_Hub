using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StoreApp.Models
{
    [Table("DispatchAgencyTbl")]
    public class DispatchAgency
    {
        [Key]
        public Int64 DispatchAgencyID { get; set; }
        public string DispatchAgencyName { get; set; }
        public string Address { get; set; }
        public string EmailID { get; set; }
        public string ContactPersonName { get; set; }
        public string MobileNo { get; set; }

    }
}
