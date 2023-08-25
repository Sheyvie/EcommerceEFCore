using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
    public class Cart
    {
        public int CartId { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }
        public string ProductName { get; set; }

        public ICollection<Product> Products { get; set;}
    }
}
