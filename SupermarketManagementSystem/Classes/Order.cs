using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagementSystem
{
    public class Order
    {
        public int BillID { get; set; }
        public List<ProdOrder> OrderList { get; set; }
    }
}
