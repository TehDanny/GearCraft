using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GearCraftClient
{
    class Item
    {
        public int Id { get; set; }
        public int RequiredLevel { get; set; }
        public string Rarity { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public List<Stat> Stats { get; set; }

        public string SetRandomRarity()
        {
            throw new NotImplementedException();

            // if unique else rare else...
        }

        public Stat AddRandomStat(int itemLevel, string itemRarity)
        {
            throw new NotImplementedException();
        }
    }

    public enum Rarity
    {
        LowQuality,
        Normal,
        Magical,
        Rare,
        Unique
    }
}
