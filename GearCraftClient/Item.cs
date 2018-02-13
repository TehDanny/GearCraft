using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GearCraftClient
{
    class Item
    {
        public int RequiredLevel { get; set; }
        public string Rarity { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public List<Stat> Stats { get; set; }

        public void GenerateItem()
        {
            throw new NotImplementedException();
        }

        public void GetItem()
        {
            throw new NotImplementedException();
        }

        private string AddRandomRarity()
        {
            throw new NotImplementedException();
        }

        private string AddRandomStat(int itemLevel, string itemRarity)
        {
            throw new NotImplementedException();
        }
    }

    public enum Rarity
    {
        LowQuality,
        Magical,
        Rare,
        Unique
    }
}
