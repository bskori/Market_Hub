using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StoreApp.Models
{
    [Table("CartTbl")]
    public class Cart
    {
        [Key]
        public Int64 CartID { get; set; }
        [ForeignKey("User")]
        public Int64 UserID { get; set; }
        [ForeignKey("Product")]
        public Int64 ProductID { get; set; }
        public int Qty { get; set; }
        public decimal Price { get; set; }
        public virtual User User { get; set; }
        public virtual Product Product { get; set; }
    }
}
