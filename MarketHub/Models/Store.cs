using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StoreApp.Models
{
    [Table("StoreTbl")]
    public class Store
    {
        [Key]
        public Int64 StoreID { get; set; }
        public string StoreName { get; set; }
        public string Address { get; set; }
        public string EmailID { get; set; }
        public string MobileNo { get; set; }
        public string Paassword { get; set; }
    }
}
