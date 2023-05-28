using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace coursework_tpr
{
    internal class Backpack
    {
        Item[] items;
        int max_size;
        int fullness;
        int best_cost;
        int s_cost;
        int p_cost;


        public int Size { get { return max_size; } }
        public int Cost { get {  return best_cost; } }
        public Item[] Items { get { return items; } }
        public int Fullness { get { return fullness; } }
        public int PCost { get { return p_cost; } }
        public int SCost { get { return s_cost; } }

        public Backpack(int max_size)
        {
            this.max_size = max_size;
            
        }
        private Backpack() { }

        public void SetBackpack(Item[] items)
        {
            
            Bpm[,] bpm = new Bpm[items.Length + 1, max_size + 1];
            for (int i = 0; i <= items.Length; ++i)
            {
                for (int w = 0; w <= max_size; ++w)
                {
                    if (i == 0 || w == 0)
                        bpm[i, w] = new Bpm(new Item[]{ }, 0);
                    else if (items[i - 1].Size <= w)
                    {
                        int new_cost = items[i - 1].Cost + bpm[i-1,w - items[i-1].Size].Cost;
                        if (bpm[i - 1, w].Cost > new_cost)
                            bpm[i, w] = bpm[i - 1, w];
                        else
                            bpm[i, w] = new Bpm(bpm[i - 1, w - items[i - 1].Size].Items.
                                Concat(new Item[] { items[i-1] }).ToArray(), new_cost);
                    }
                    else
                        bpm[i, w] = bpm[i-1, w];
                }
            }
            this.items = bpm[bpm.GetLength(0)-1, bpm.GetLength(1)-1].Items;
            best_cost = bpm[bpm.GetLength(0) - 1, bpm.GetLength(1) - 1].Cost;
            Calc();
        }
        
        private void Calc()
        {
            foreach (Item item in items)
            {
                p_cost += item.PCost;
                s_cost += item.SCost;
                fullness += item.Size;
            }

        }


    }
}
