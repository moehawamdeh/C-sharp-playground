using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cashier_GUI
{
    class ItemList
    {
        private List<string> Items;
        private List<double> prices;

        public ItemList()
        {
           this.Items=new List<string>();
           this.prices=new List<double>();
        }

        public void addItem(string item,double price)
        {
            this.Items.Add(item);
            this.prices.Add(price);
        }
        public double totalSale()
        {
            double total = 0;
            foreach (double p in prices)
                total += p;
            return total;
        }
    }
}
