using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using testMark.Interface;
using testMark.Models;

namespace testMark.Repositories
{
    public class ProductRepository : IProductRepository
    {
        ProductContext ProductDB = new ProductContext();
        public Product Add(Product item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            ProductDB.Products.Add(item);
            ProductDB.SaveChanges();
            return item;
        }

        public bool Delete(int id)
        {
            Product products = ProductDB.Products.Find(id);
            ProductDB.Products.Remove(products);
            ProductDB.SaveChanges();
            return true;
        }

        public Product Get(int id)
        {
            return ProductDB.Products.Find(id);
        }

        public IEnumerable<Product> GetAll()
        {
            return ProductDB.Products.ToList();
        }

        public bool Update(Product item)
        {
            if(item == null)
            {
                throw new ArgumentNullException("item");
            }
            var products = ProductDB.Products.Single(a => a.id == item.id);
            products.artNo = item.artNo;
            products.price = item.price;
            products.shortText = item.shortText;
            ProductDB.SaveChanges();

            return true;
        }
    }
}