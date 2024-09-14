using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesDatabase.Models
{
    internal class Sale
    {
        public int SaleId { get; set; }
        public int Data {  get; set; }
        public List<Product> products { get; set; }
        public List<Customer> customers { get; set; }
        public List<Store> stores { get; set; }
    }
}
