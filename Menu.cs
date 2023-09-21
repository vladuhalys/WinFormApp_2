using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormApp_2
{
    public class MenuItem
    {
        public string Name { get; set; }
        public int Count { get; set; }
        public double DefaultPrice { get; set; }
        public double PriceAll { get; set; }
        public MenuItem() {
            Name = "";
            Count = 0;
            DefaultPrice = 0;
            PriceAll = 0;
        }
        public MenuItem(string name, int count, double defaultPrice)
        {
            Name = name;
            Count = count;
            DefaultPrice = defaultPrice;
            if (count > 0)
                PriceAll = defaultPrice * count;
            else
                PriceAll = 0;
        }
        public void SetCount(int count)
        {
            Count = count;
            if (count > 0)
                PriceAll = DefaultPrice * count;
            else
                PriceAll = 0;
        }
    }
    public class Menu
    {
        public List<MenuItem> Items = new List<MenuItem>();
    }
}
