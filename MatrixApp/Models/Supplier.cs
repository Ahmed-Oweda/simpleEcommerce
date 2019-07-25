using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MatrixApp.Models
{
    [Table("Supplier")]
    public class Supplier
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int PhoneNum { get; set; }

        
      


    }
}