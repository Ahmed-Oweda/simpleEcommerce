using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MatrixApp.Models
{
    [Table("SubCategoryLv1")]
    public class SubCategoryLv1 
    {
        public int Id { get; set; }
        public string devices { get; set; }

        public Category Category { get; set; }
    }
}