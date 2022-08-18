using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagementSystem
{
    public class ProdOrder
    {
        public ProdOrder(string prodName, int prodQuantity, double prodPrice)
        {
            //this.BillID = billID;
            this.ProdName = prodName;
            this.ProdQuantity = prodQuantity;
            this.ProdPrice = prodPrice;
        }
        //public int BillID { get; set; }
        public string ProdName { get; set; }
        public int ProdQuantity { get; set; }
        public double ProdPrice { get; set; }
    }
}
