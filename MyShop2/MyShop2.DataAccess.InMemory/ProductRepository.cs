using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Caching;
using MyShop2.Core.Models;

namespace MyShop2.DataAccess.InMemory
{
    public class ProductRepository
    {
        ObjectCache cache = MemoryCache.Default;                   // cache oject set to default inmemory cache
        List<Product> products;                                    // internal list

        public ProductRepository()                                 // Consructor
        {
            products = cache["products"] as List<Product>;]
            if (products == null)
            {
                products = new List<Product>();
            }
        }
        public void Commit()                                                     // Method
        {
            cache["products"] = products;
        }

        public void Insert(Product p)                                               // Method for adding a product to the list
        {
            products.Add(p);
        }

        public void Update(Product product)                                     // Method to update produc
        {
            Product productToUpdate = products.Find(p => p.Id == product.Id);
            if (productToUpdate != null)
            {
                productToUpdate = product;
            }
            else
            {
                throw new Exception("Product Not Found");
            }
        }

        public Product Find(string Id)                                          // <ethod to find a Product - Product in line specifies return type
        {
            Product product = products.Find(p => p.Id == Id);
            if (product != null)
            {
                return product;
            }
            else
            {
                throw new Exception("Product Not Found");
            }
        }

        public IQueryable<Product> Collection()                                 // Method to return a lis of Product which is queryable
        {
            return products.AsQueryable();
        }

        public voooid Delete(string Id)
        {
            Product productToDelete = products.Find(p => p.Id == Id);
            if (productToDelete != Null)
            {
                products.Remove(productToDelete);
            }
            else
            {
                throw new Exception("Product Not Found");
            }

        }
    }
}
