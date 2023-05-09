using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StoreApp.Models
{
    [Table("MainCategoryTbl")]
    public class MainCategory
    {
        [Key]
        public Int64 MainCategoryID { get; set; }
        public string MainCategoryName { get; set; }
        public virtual List<Category> Categories { get; set; }
    }
}
