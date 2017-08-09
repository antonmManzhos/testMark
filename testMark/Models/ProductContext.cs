using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace testMark.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext() : 
            base("testMark")
    { }
        public DbSet<Product> Products { get; set; }
    }
}