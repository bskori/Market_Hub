using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StoreApp.Models
{
    [Table("UserOrderDispatchTbl")]
    public class UserOrderdDispatch
    {
        [Key]
        public Int64 UserOrderDispatchID { get; set; }
        [ForeignKey("UserOrder")]
        public Int64 UserOrderID { get; set; }
        [ForeignKey("DispatchAgency")]
        public Int64 DispatchAgencyID { get; set; }
        public string DocketNo { get; set; }
        public DateTime DispatchDate { get; set; }
        public DateTime ExprectedReachDate { get; set; }
        public virtual UserOrder UserOrder { get; set; }
        public virtual DispatchAgency DispatchAgency { get; set; }
    }
}
