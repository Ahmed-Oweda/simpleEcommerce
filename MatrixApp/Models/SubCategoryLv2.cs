using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MatrixApp.Models
{
    [Table("SubCategoryLv2")]
    public class SubCategoryLv2 
    {
        public int Id { get; set; }
        public int RangeOfPrices { get; set; }

        public SubCategoryLv1 SubCat { get; set; }


    }
}