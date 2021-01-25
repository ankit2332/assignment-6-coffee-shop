using System;
using System.Collections.Generic;
using System.Text;

namespace assignment_6_coffee_shop
{
    class drink
    {
        private string name;
        private int price;

        public drink(string name, int price)
        {
            this.name = name;
            this.price = price;
        }

        public string getname()
        {
            return name;
        }

        public int getprice()
        {
            return price;
        }
    }

}
