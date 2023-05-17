using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coursework_tpr
{
    internal class Bpm
    {
        private Item[] items;
        private int cost;
        public Item[] Items { get { return items; } }
        public int Cost { get { return cost; } }
        public Bpm(Item[] items, int cost)
        {
            this.items = items;
            this.cost = cost;
        }
    }
}
