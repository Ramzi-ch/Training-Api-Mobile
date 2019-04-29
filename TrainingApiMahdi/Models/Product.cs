using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrainingApiMahdi.Models
{
    public class Product
    {
        public int id { get; set; }
        public string name { get; set; }


        public static List<Product> ListProduct = new List<Product>()
        {
            new Product {id=0,name="Pen"},
            new Product {id=1,name="book"},
            new Product {id=2,name="cake"},
        };
    }
}