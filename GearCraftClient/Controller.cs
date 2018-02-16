using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GearCraftClient
{
    class Controller
    {
        private ItemStorage itemStorage;
        
        public Controller()
	    {
            itemStorage = new ItemStorage();
	    }

        public void GenerateItem()
        {
            Item item = new Item();
            item.Rarity = item.SetRandomRarity();
            item.Stats.Add(item.AddRandomStat(item.RequiredLevel, item.Rarity));
        }

        public Item GetItem(int itemId)
        {
            return itemStorage.GetItem(itemId);
        }
    }
}
