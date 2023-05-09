using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StoreApp.Models
{
    [Table("UserOrderTbl")]
    public class UserOrder
    {
        [Key]
        public Int64 UserOrderID { get; set; }
        public DateTime OrderDateTime { get; set; }
        public bool IsPaid { get; set; }
        [ForeignKey("User")]
        public Int64 UserID { get; set; }
        public virtual User User { get; set; }
        public virtual List<UserOrderDet> UserOrderDets { get; set; }

        public UserOrder()
        {
            UserOrderDets = new List<UserOrderDet>();
        }
    }
}
