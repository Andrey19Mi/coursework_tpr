using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coursework_tpr
{
    internal class Item
    {
        string name = "none";
        int size = 0;
        int cost = 0;
        int s_cost = 0;
        int p_cost = 0;
        int count = 0;

        public string Name { get { return name; } }
        public int Size { get { return size; } }
        public int Cost { get { return cost; } }
        public int PCost { get { return p_cost; } }
        public int SCost { get { return s_cost; } }
        public int Count { get { return count; } set { count = value; } }

        public Item(string name, int size, int s_cost, int p_cost)
        {
            this.name = name;
            this.size = size;
            this.s_cost = s_cost;
            this.p_cost = p_cost;
            cost = s_cost - p_cost;

        }
        public Item(Item item, int count)
        {
            name = item.Name;
            size = item.Size;
            cost = item.Cost;
            p_cost = item.PCost;
            s_cost = item.SCost;
            this.count = count;
        }
        public string[] Print()
        {
            return new string[] { name, size.ToString(), cost.ToString(),
                s_cost.ToString(), p_cost.ToString()};
        }
    }
}
