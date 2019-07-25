using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MatrixApp.Models
{
    [Table("Product")]
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int NoInStock { get; set; }

        public int Price { get; set; }

        
        public  SubCategoryLv2 SubCategoryLv2 { get; set; }

        public Supplier Supplier { get; set; }
    }
}