using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop2.Core.Models
{
    public class ProductCategory : BaseEntity
    {
     //   public string Id { get; set; }                  // property
        public string Category { get; set; }             // property

   /*     public ProductCategory()                        // constrictor to assign a value to Id
        {
            this.Id = Guid.NewGuid().ToString();
        }
  */
    }
}
