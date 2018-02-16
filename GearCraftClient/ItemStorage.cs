using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GearCraftClient
{
    class ItemStorage
    {
        public List<Item> Items;

        public ItemStorage()
        {
            Items = new List<Item>();
        }

        public void AddItem(Item item)
        {
            Items.Add(item);
        }

        public Item GetItem(int itemId)
        {
            return Items.Find(item => item.Id == itemId);
        }
    }
}
